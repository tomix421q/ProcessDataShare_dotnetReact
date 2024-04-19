using api.DbData;
using api.Interfaces.CollectToDb;

namespace api.Services
{
    public class AsqCollectorDb : BackgroundService
    {
        readonly ILogger<AsqCollectorDb> _logger;

        private IServiceProvider _serviceProvider;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);

        public AsqCollectorDb(ILogger<AsqCollectorDb> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            DateTime lastSaveTimeAsq2A = DateTime.MinValue;
            DateTime lastSaveTimeAsq2B = DateTime.MinValue;
            DateTime lastSaveTimeAsq3A = DateTime.MinValue;
            DateTime lastSaveTimeAsq3B = DateTime.MinValue;
            DateTime lastSaveTimeAsq4A = DateTime.MinValue;
            DateTime lastSaveTimeAsq4B = DateTime.MinValue;
            DateTime lastSaveTimeAsq5A = DateTime.MinValue;
            DateTime lastSaveTimeAsq5B = DateTime.MinValue;
            DateTime lastSaveTimeAsq6A = DateTime.MinValue;
            DateTime lastSaveTimeAsq6B = DateTime.MinValue;

            //unlockers
            bool asq2A_unlock = false;
            bool asq2B_unlock = false;
            bool asq3A_unlock = false;
            bool asq3B_unlock = false;
            bool asq4A_unlock = false;
            bool asq4B_unlock = false;
            bool asq5A_unlock = false;
            bool asq5B_unlock = false;
            bool asq6A_unlock = false;
            bool asq6B_unlock = false;


            // Try to connect
            using var scope = _serviceProvider.CreateScope();
            await using var context = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
            var AsqDbDataRepo = scope.ServiceProvider.GetRequiredService<IAsqDataDb>();

            while (!stoppingToken.IsCancellationRequested)
            {
                // CHECK CONNECT IP
                var (success_asq2, errorMessage_asq2) = await AsqDbDataRepo.SetIpAddress_asq2("10.184.159.109");
                var (success_asq3, errorMessage_asq3) = await AsqDbDataRepo.SetIpAddress_asq3("10.184.159.240");
                var (success_asq4, errorMessage_asq4) = await AsqDbDataRepo.SetIpAddress_asq4("10.184.159.12");
                var (success_asq5, errorMessage_asq5) = await AsqDbDataRepo.SetIpAddress_asq5("10.184.159.108");
                var (success_asq6, errorMessage_asq6) = await AsqDbDataRepo.SetIpAddress_asq6("10.184.159.184");
                await _semaphore.WaitAsync(stoppingToken); // Počkajte na voľný slot

                try
                {
                    //________________ASQ_2_________________
                    if (success_asq2)
                    {
                        // _logger.LogInformation("cakam ASQ______________2");
                        var resultAsq2 = await AsqDbDataRepo.GetLiveDataToDb_asq2();
                        if (resultAsq2.ROB1_ActStep == 3 || resultAsq2.ROB1_ActStep == 4) asq2A_unlock = true;
                        if (resultAsq2.ROB2_ActStep == 3 || resultAsq2.ROB2_ActStep == 4) asq2B_unlock = true;
                        // 
                        if (resultAsq2.ROB1_ActStep == 6 && DateTime.Now > lastSaveTimeAsq2A.AddSeconds(10) && asq2A_unlock == true)
                        {
                            var resultAsq2a = await AsqDbDataRepo.GetLiveDataToDb_asq2();
                            resultAsq2a.Product_A = true;
                            await context.AsqDatas_asq2.AddAsync(resultAsq2a);
                            lastSaveTimeAsq2A = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_2_A : {time}", DateTimeOffset.Now);
                            asq2A_unlock = false;
                        }
                        if (resultAsq2.ROB2_ActStep == 6 && DateTime.Now > lastSaveTimeAsq2B.AddSeconds(10) && asq2B_unlock == true)
                        {
                            var resultAsq2b = await AsqDbDataRepo.GetLiveDataToDb_asq2();
                            resultAsq2b.Product_B = true;
                            await context.AsqDatas_asq2.AddAsync(resultAsq2b);
                            lastSaveTimeAsq2B = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_2_B : {time}", DateTimeOffset.Now);
                            asq2B_unlock = false;
                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection ASQ_2 : {time}", DateTimeOffset.Now);
                    }


                    //________________ASQ_3_________________
                    if (success_asq3)
                    {
                        // _logger.LogInformation("cakam ASQ______________3");
                        var resultAsq3 = await AsqDbDataRepo.GetLiveDataToDb_asq3();
                        if (resultAsq3.ROB1_ActStep == 3 || resultAsq3.ROB1_ActStep == 4) asq3A_unlock = true;
                        if (resultAsq3.ROB2_ActStep == 3 || resultAsq3.ROB2_ActStep == 4) asq3B_unlock = true;
                        // 
                        if (resultAsq3.ROB1_ActStep == 6 && DateTime.Now > lastSaveTimeAsq3A.AddSeconds(10) && asq3A_unlock == true)
                        {
                            var resultAsq3a = await AsqDbDataRepo.GetLiveDataToDb_asq3();
                            resultAsq3a.Product_A = true;
                            await context.AsqDatas_asq3.AddAsync(resultAsq3a);
                            lastSaveTimeAsq3A = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_3_A : {time}", DateTimeOffset.Now);
                            asq3A_unlock = false;

                        }
                        if (resultAsq3.ROB2_ActStep == 6 && DateTime.Now > lastSaveTimeAsq3B.AddSeconds(10) && asq3B_unlock == true)
                        {
                            var resultAsq3b = await AsqDbDataRepo.GetLiveDataToDb_asq3();
                            resultAsq3b.Product_B = true;
                            await context.AsqDatas_asq3.AddAsync(resultAsq3b);
                            lastSaveTimeAsq3B = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_3_B : {time}", DateTimeOffset.Now);
                            asq3B_unlock = false;

                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection ASQ_3 : {time}", DateTimeOffset.Now);
                    }


                    //________________ASQ_4_________________
                    if (success_asq4)
                    {
                        // _logger.LogInformation("cakam ASQ______________4");
                        var resultAsq4 = await AsqDbDataRepo.GetLiveDataToDb_asq4();
                        if (resultAsq4.ROB1_ActStep == 3 || resultAsq4.ROB1_ActStep == 4) asq4A_unlock = true;
                        if (resultAsq4.ROB2_ActStep == 3 || resultAsq4.ROB2_ActStep == 4) asq4B_unlock = true;
                        // 
                        if (resultAsq4.ROB1_ActStep == 6 && DateTime.Now > lastSaveTimeAsq4A.AddSeconds(10) && asq4A_unlock == true)
                        {
                            var resultAsq4a = await AsqDbDataRepo.GetLiveDataToDb_asq4();
                            resultAsq4a.Product_A = true;
                            await context.AsqDatas_asq4.AddAsync(resultAsq4a);
                            lastSaveTimeAsq4A = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_4_A : {time}", DateTimeOffset.Now);
                            asq4A_unlock = false;

                        }
                        if (resultAsq4.ROB2_ActStep == 6 && DateTime.Now > lastSaveTimeAsq3B.AddSeconds(10) && asq4B_unlock == true)
                        {
                            var resultAsq4b = await AsqDbDataRepo.GetLiveDataToDb_asq4();
                            resultAsq4b.Product_B = true;
                            await context.AsqDatas_asq4.AddAsync(resultAsq4b);
                            lastSaveTimeAsq4B = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_4_B : {time}", DateTimeOffset.Now);
                            asq4B_unlock = false;

                        };
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection ASQ_4 : {time}", DateTimeOffset.Now);
                    }

                    //________________ASQ_5_________________
                    if (success_asq5)
                    {
                        // _logger.LogInformation("cakam ASQ______________5");
                        var resultAsq5 = await AsqDbDataRepo.GetLiveDataToDb_asq5();
                        if (resultAsq5.ROB1_ActStep == 4 || resultAsq5.ROB1_ActStep == 3) asq5A_unlock = true;
                        if (resultAsq5.ROB2_ActStep == 4 || resultAsq5.ROB2_ActStep == 3) asq5B_unlock = true;
                        // 
                        if (resultAsq5.ROB1_ActStep == 6 && DateTime.Now > lastSaveTimeAsq5A.AddSeconds(10) && asq5A_unlock == true)
                        {
                            var resultAsq5a = await AsqDbDataRepo.GetLiveDataToDb_asq5();
                            resultAsq5a.Product_A = true;
                            await context.AsqDatas_asq5.AddAsync(resultAsq5a);
                            lastSaveTimeAsq5A = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_5_A : {time}", DateTimeOffset.Now);
                            asq5A_unlock = false;

                        }
                        if (resultAsq5.ROB2_ActStep == 6 && DateTime.Now > lastSaveTimeAsq5B.AddSeconds(10) && asq5B_unlock == true)
                        {
                            var resultAsq5b = await AsqDbDataRepo.GetLiveDataToDb_asq5();
                            resultAsq5b.Product_B = true;
                            await context.AsqDatas_asq5.AddAsync(resultAsq5b);
                            lastSaveTimeAsq5B = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_5_B : {time}", DateTimeOffset.Now);
                            asq5B_unlock = false;


                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection ASQ_5 : {time}", DateTimeOffset.Now);
                    }

                    //________________ASQ_6_________________
                    if (success_asq6)
                    {
                        // _logger.LogInformation("cakam ASQ______________6");
                        var resultAsq6 = await AsqDbDataRepo.GetLiveDataToDb_asq6();
                        if (resultAsq6.ROB1_ActStep == 3 || resultAsq6.ROB1_ActStep == 4) asq6A_unlock = true;
                        if (resultAsq6.ROB2_ActStep == 3 || resultAsq6.ROB2_ActStep == 4) asq6B_unlock = true;
                        // 
                        if (resultAsq6.ROB1_ActStep == 6 && DateTime.Now > lastSaveTimeAsq6A.AddSeconds(10) && asq6A_unlock == true)
                        {
                            var resultAsq6a = await AsqDbDataRepo.GetLiveDataToDb_asq6();
                            resultAsq6a.Product_A = true;
                            await context.AsqDatas_asq6.AddAsync(resultAsq6a);
                            lastSaveTimeAsq6A = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq6_A : {time}", DateTimeOffset.Now);
                            asq6A_unlock = false;

                        }
                        if (resultAsq6.ROB2_ActStep == 6 && DateTime.Now > lastSaveTimeAsq6B.AddSeconds(10) && asq6B_unlock == true)
                        {
                            var resultAsq6b = await AsqDbDataRepo.GetLiveDataToDb_asq6();
                            resultAsq6b.Product_B = true;
                            await context.AsqDatas_asq6.AddAsync(resultAsq6b);
                            lastSaveTimeAsq6B = DateTime.Now;
                            await context.SaveChangesAsync();
                            _logger.LogInformation("Database shot => asq_6_B : {time}", DateTimeOffset.Now);
                            asq6B_unlock = false;

                        }
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection ASQ_6 : {time}", DateTimeOffset.Now);
                    }



                    await Task.Delay(100, stoppingToken);
                }
                finally
                {
                    _semaphore.Release(); //release }

                }
            }
        }
    }
}