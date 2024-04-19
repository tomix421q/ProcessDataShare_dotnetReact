using api.DbData;
using api.Interfaces.CollectToDb;

namespace api.Services
{
    public class EqcCollectorDb : BackgroundService
    {
        readonly ILogger<EqcCollectorDb> _logger;
        private IServiceProvider _serviceProvider;
        private readonly IEqcDataDb _eqcDbTo;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);
        public EqcCollectorDb(ILogger<EqcCollectorDb> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;

        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            DateTime lastSaveTimeEqc1 = DateTime.MinValue;
            DateTime lastSaveTimeEqc2 = DateTime.MinValue;
            DateTime lastSaveTimeEqc3 = DateTime.MinValue;
            DateTime lastSaveTimeEqc4 = DateTime.MinValue;
            DateTime lastSaveTimeEqc5 = DateTime.MinValue;
            DateTime lastSaveTimeEqc6 = DateTime.MinValue;
            DateTime lastSaveTimeEqc7 = DateTime.MinValue;
            DateTime lastSaveTimeEqc8 = DateTime.MinValue;

            // Try to connect
            using var scope = _serviceProvider.CreateScope();
            await using var context = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
            var EqcDbDataRepo = scope.ServiceProvider.GetRequiredService<IEqcDataDb>();

            while (!stoppingToken.IsCancellationRequested)
            {
                // CHECK CONNECT IP
                var (success_eqc1, errorMessage_eqc1) = await EqcDbDataRepo.SetIpAddress_eqc1("10.184.159.173");
                var (success_eqc2, errorMessage_eqc2) = await EqcDbDataRepo.SetIpAddress_eqc2("10.184.159.174");
                var (success_eqc3, errorMessage_eqc3) = await EqcDbDataRepo.SetIpAddress_eqc3("10.184.159.175");
                var (success_eqc4, errorMessage_eqc4) = await EqcDbDataRepo.SetIpAddress_eqc4("10.184.159.176");
                var (success_eqc5, errorMessage_eqc5) = await EqcDbDataRepo.SetIpAddress_eqc5("10.184.159.89");
                var (success_eqc6, errorMessage_eqc6) = await EqcDbDataRepo.SetIpAddress_eqc6("10.184.159.99");
                var (success_eqc7, errorMessage_eqc7) = await EqcDbDataRepo.SetIpAddress_eqc7("10.184.159.171");
                var (success_eqc8, errorMessage_eqc8) = await EqcDbDataRepo.SetIpAddress_eqc8("10.184.159.101");
                await _semaphore.WaitAsync(stoppingToken); // Počkajte na voľný slot

                try
                {



                    //_________EQC_1_________
                    if (success_eqc1)
                    {
                        var resultEqc1 = await EqcDbDataRepo.GetLiveDataToDb_eqc1();
                        if (resultEqc1.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc1.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc1.AddAsync(resultEqc1);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc1 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc1 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC1 : {time}", DateTimeOffset.Now);
                    }


                    //__________EQC_2_________
                    if (success_eqc2)
                    {

                        var resultEqc2 = await EqcDbDataRepo.GetLiveDataToDb_eqc2();
                        if (resultEqc2.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc2.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc2.AddAsync(resultEqc2);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc2 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc2 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC2 : {time}", DateTimeOffset.Now);
                    }


                    //__________EQC_3_________
                    if (success_eqc3)
                    {
                        var resultEqc3 = await EqcDbDataRepo.GetLiveDataToDb_eqc3();
                        if (resultEqc3.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc3.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc3.AddAsync(resultEqc3);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc3 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc3 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC3 : {time}", DateTimeOffset.Now);
                    }

                    //____________EQC_4____________
                    if (success_eqc4)
                    {

                        var resultEqc4 = await EqcDbDataRepo.GetLiveDataToDb_eqc4();
                        if (resultEqc4.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc4.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc4.AddAsync(resultEqc4);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc5 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc4 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC4 : {time}", DateTimeOffset.Now);
                    }

                    //__________EQC_5__________
                    if (success_eqc5)
                    {
                        // _logger.LogInformation("cakam eqc5");
                        var resultEqc5 = await EqcDbDataRepo.GetLiveDataToDb_eqc5();

                        // WRITE TO DB
                        if (resultEqc5.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc5.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc5.AddAsync(resultEqc5);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc5 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc5 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC5 : {time}", DateTimeOffset.Now);
                    }

                    //__________EQC_6__________
                    if (success_eqc6)
                    {
                        // _logger.LogInformation("cakam eqc6");
                        var resultEqc6 = await EqcDbDataRepo.GetLiveDataToDb_eqc6();

                        // WRITE TO DB
                        if (resultEqc6.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc6.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc6.AddAsync(resultEqc6);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc6 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc6 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC6 : {time}", DateTimeOffset.Now);
                    }

                    //____________EQC_7______________
                    if (success_eqc7)
                    {
                        // _logger.LogInformation("cakam eqc7");
                        var resultEqc7 = await EqcDbDataRepo.GetLiveDataToDb_eqc7();

                        // WRITE TO DB
                        if (resultEqc7.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc7.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc7.AddAsync(resultEqc7);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc7 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc7 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC7 : {time}", DateTimeOffset.Now);
                    }

                    //_____________EQC_8______________
                    if (success_eqc8)
                    {
                        // _logger.LogInformation("cakam eqc8");
                        var resultEqc8 = await EqcDbDataRepo.GetLiveDataToDb_eqc8();

                        // WRITE TO DB
                        if (resultEqc8.MainStepNumber == 15 && DateTime.Now > lastSaveTimeEqc8.AddSeconds(40))
                        {
                            await context.EqcDatas_eqc8.AddAsync(resultEqc8);
                            await context.SaveChangesAsync();
                            lastSaveTimeEqc8 = DateTime.Now;
                            _logger.LogInformation("Database shot => eqc8 : {time}", DateTimeOffset.Now);
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC8 : {time}", DateTimeOffset.Now);
                    }


                    // 
                    await Task.Delay(500, stoppingToken);
                }









                // 
                // 
                finally
                {
                    _semaphore.Release(); //release
                }
            }
        }
    }
}
