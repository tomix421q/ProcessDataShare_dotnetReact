using api.Interfaces.CollectToDb;
using api.DbData;

namespace api.Services
{
      public class OpelCollectorDb : BackgroundService
      {
            readonly ILogger<OpelCollectorDb> _logger;
            private IServiceProvider _serviceProvider;
            private readonly IOpelDataDb _opelDb;
            private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);

            public OpelCollectorDb(ILogger<OpelCollectorDb> logger, IServiceProvider serviceProvider)
            {
                  _logger = logger;
                  _serviceProvider = serviceProvider;
            }

            protected async override Task ExecuteAsync(CancellationToken stoppingToken)
            {
                  DateTime lastSaveTime_ArmrestFr = DateTime.MinValue;
                  DateTime lastSaveTime_ArmrestRr = DateTime.MinValue;
                  DateTime lastSaveTime_InsertFr = DateTime.MinValue;
                  DateTime lastSaveTime_InsertRr = DateTime.MinValue;

                  //Try to connect
                  using var scope = _serviceProvider.CreateScope();
                  await using var context = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();

                  var opelDbDataRepo = scope.ServiceProvider.GetRequiredService<IOpelDataDb>();



                  while (!stoppingToken.IsCancellationRequested)
                  {

                        var (success_armrestFr, errorMessage_armrestFr) = await opelDbDataRepo.SetIpAddress_opelArmrest_Fr("10.184.159.45");
                        var (success_armrestRr, errorMessage_armrestRr) = await opelDbDataRepo.SetIpAddress_opelArmrest_Rr("10.184.159.46");
                        // var (success_insertFr, errorMessage_insertFr) = await opelDbDataRepo.SetIpAddress_opelInsert_Fr("10.184.159.48");
                        // var (success_insertRr, errorMessage_insertRr) = await opelDbDataRepo.SetIpAddress_opelInsert_Rr("10.184.159.47");

                        await _semaphore.WaitAsync(stoppingToken);

                        try
                        {
                              //Armrest FR
                              if (success_armrestFr)
                              {
                                    var resultArmrestFr = await opelDbDataRepo.GetLiveDataToDb_opelArmrest_Fr();

                                    if (resultArmrestFr.TimeStamp.Hour == 9 || resultArmrestFr.TimeStamp.Hour == 13 || resultArmrestFr.TimeStamp.Hour == 16 || resultArmrestFr.TimeStamp.Hour == 19 && DateTime.Now > lastSaveTime_ArmrestFr.AddSeconds(40))
                                    {
                                          await context.OpelArmrestFr_data.AddAsync(resultArmrestFr);
                                          await context.SaveChangesAsync();
                                          lastSaveTime_ArmrestFr = DateTime.Now;
                                          _logger.LogInformation("Database shot => Armrest FR temp water : {time}", DateTimeOffset.Now);
                                    }
                              }
                              else
                              {
                                    _logger.LogInformation("Problem with connection Opel Armrest FR : {time}", DateTimeOffset.Now);
                              }

                              //Armrest RR
                              if (success_armrestRr)
                              {
                                    var resultArmrestRr = await opelDbDataRepo.GetLiveDataToDb_opelArmrest_Rr();

                                    if (resultArmrestRr.TimeStamp.Hour == 9 || resultArmrestRr.TimeStamp.Hour == 13 || resultArmrestRr.TimeStamp.Hour == 16 || resultArmrestRr.TimeStamp.Hour == 19 && DateTime.Now > lastSaveTime_ArmrestRr.AddSeconds(40))
                                    {
                                          await context.OpelArmrestRr_data.AddAsync(resultArmrestRr);
                                          await context.SaveChangesAsync();
                                          lastSaveTime_ArmrestRr = DateTime.Now;
                                          _logger.LogInformation("Database shot => Armrest RR temp water : {time}", DateTimeOffset.Now);
                                    }
                              }
                              else
                              {
                                    _logger.LogInformation("Problem with connection Opel Armrest RR : {time}", DateTimeOffset.Now);
                              }






                              await Task.Delay(500, stoppingToken);
                        }
                        finally
                        {
                              _semaphore.Release();
                        }

                  }
            }



      }
}