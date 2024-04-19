using api.DbData;
using api.Helpers;
using api.Interfaces.CollectFromDb;
using api.Models.databaseModels.ASQ;
using api.Models.databaseModels.EQC;
using Microsoft.EntityFrameworkCore;

namespace api.Repository.DataFromDb
{
    public class DataFromDbRepo : IDataFromDb
    {
        private int _totalRecords;
        private readonly ApplicationDBContext _context;

        public DataFromDbRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<int> GetNumRecords()
        {
            int totalRec = _totalRecords;
            return totalRec;
        }

        // _____________________EQC_1_____________________
        public async Task<List<Db_eqc1Model>> GetAllEqc1Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc1.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;

        }


        // _____________________EQC_2_____________________
        public async Task<List<Db_eqc2Model>> GetAllEqc2Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc2.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }


        // _____________________EQC_3_____________________
        public async Task<List<Db_eqc3Model>> GetAllEqc3Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc3.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }

        // _____________________EQC_4_____________________
        public async Task<List<Db_eqc4Model>> GetAllEqc4Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc4.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }


        // _____________________EQC_5_____________________
        public async Task<List<Db_eqc5Model>> GetAllEqc5Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc5.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }



        // _____________________EQC_6_____________________
        public async Task<List<Db_eqc6Model>> GetAllEqc6Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc6.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }


        // _____________________EQC_7_____________________
        public async Task<List<Db_eqc7Model>> GetAllEqc7Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc7.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }

        // _____________________EQC_8_____________________
        public async Task<List<Db_eqc8Model>> GetAllEqc8Async(QueryObject query)
        {
            var eqcdb = _context.EqcDatas_eqc8.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.TimeStamp <= query.DateTo);
            }

            if (query.ToolNum.HasValue)
            {
                eqcdb = eqcdb.Where(s => s.ToolNumber == query.ToolNum.Value);
            }

            eqcdb = query.IsDecsending ? eqcdb.OrderByDescending(s => s.TimeStamp) : eqcdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await eqcdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await eqcdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }


        // 
        // ASQ DB
        // 
        public async Task<List<Db_asq2Model>> GetAllAsq2Async(QueryObject query)
        {
            var asqdb = _context.AsqDatas_asq2.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp <= query.DateTo);
            }
            if (query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.Product_A == query.SelectAsq_A);
            }
            if (query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.Product_B == query.SelectAsq_B);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.ROB1_FormNumber == query.ToolNum.Value);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.ROB2_FormNumber == query.ToolNum.Value);
            }

            asqdb = query.IsDecsending ? asqdb.OrderByDescending(s => s.TimeStamp) : asqdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await asqdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await asqdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }

        public async Task<List<Db_asq3Model>> GetAllAsq3Async(QueryObject query)
        {
            var asqdb = _context.AsqDatas_asq3.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp <= query.DateTo);
            }
            if (query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.Product_A == query.SelectAsq_A);
            }
            if (query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.Product_B == query.SelectAsq_B);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.ROB1_FormNumber == query.ToolNum.Value);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.ROB2_FormNumber == query.ToolNum.Value);
            }

            asqdb = query.IsDecsending ? asqdb.OrderByDescending(s => s.TimeStamp) : asqdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await asqdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await asqdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }

        public async Task<List<Db_asq4Model>> GetAllAsq4Async(QueryObject query)
        {
            var asqdb = _context.AsqDatas_asq4.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp <= query.DateTo);
            }
            if (query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.Product_A == query.SelectAsq_A);
            }
            if (query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.Product_B == query.SelectAsq_B);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.ROB1_FormNumber == query.ToolNum.Value);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.ROB2_FormNumber == query.ToolNum.Value);
            }

            asqdb = query.IsDecsending ? asqdb.OrderByDescending(s => s.TimeStamp) : asqdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await asqdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await asqdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }

        public async Task<List<Db_asq5Model>> GetAllAsq5Async(QueryObject query)
        {
            var asqdb = _context.AsqDatas_asq5.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp <= query.DateTo);
            }
            if (query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.Product_A == query.SelectAsq_A);
            }
            if (query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.Product_B == query.SelectAsq_B);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.ROB1_FormNumber == query.ToolNum.Value);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.ROB2_FormNumber == query.ToolNum.Value);
            }

            asqdb = query.IsDecsending ? asqdb.OrderByDescending(s => s.TimeStamp) : asqdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await asqdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await asqdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }

        public async Task<List<Db_asq6Model>> GetAllAsq6Async(QueryObject query)
        {
            var asqdb = _context.AsqDatas_asq6.AsQueryable();

            if (query.DateFrom.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp >= query.DateFrom);
            }

            if (query.DateTo.HasValue)
            {
                asqdb = asqdb.Where(s => s.TimeStamp <= query.DateTo);
            }
            if (query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.Product_A == query.SelectAsq_A);
            }
            if (query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.Product_B == query.SelectAsq_B);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_A == true)
            {
                asqdb = asqdb.Where(s => s.ROB1_FormNumber == query.ToolNum.Value);
            }
            if (query.ToolNum.HasValue && query.SelectAsq_B == true)
            {
                asqdb = asqdb.Where(s => s.ROB2_FormNumber == query.ToolNum.Value);
            }

            asqdb = query.IsDecsending ? asqdb.OrderByDescending(s => s.TimeStamp) : asqdb.OrderBy(s => s.TimeStamp);
            var totalRecords = await asqdb.CountAsync();
            _totalRecords = totalRecords;
            var skimNumber = (query.PageNumber - 1) * query.PageSize;
            var data = await asqdb.Skip(skimNumber).Take(query.PageSize).ToListAsync();
            return data;
        }
    }
}