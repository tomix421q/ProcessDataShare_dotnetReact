using api.Models.databaseModels.ASQ;
using api.Models.databaseModels.EQC;
using api.Models.databaseModels.OPEL;
using Microsoft.EntityFrameworkCore;

namespace api.DbData
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions dbContenxtOptions) : base(dbContenxtOptions)
        {

        }

        // ASQ
        public DbSet<Db_asq2Model> AsqDatas_asq2 { get; set; }
        public DbSet<Db_asq3Model> AsqDatas_asq3 { get; set; }
        public DbSet<Db_asq4Model> AsqDatas_asq4 { get; set; }
        public DbSet<Db_asq5Model> AsqDatas_asq5 { get; set; }
        public DbSet<Db_asq6Model> AsqDatas_asq6 { get; set; }
        // EQC
        public DbSet<Db_eqc1Model> EqcDatas_eqc1 { get; set; }
        public DbSet<Db_eqc2Model> EqcDatas_eqc2 { get; set; }
        public DbSet<Db_eqc3Model> EqcDatas_eqc3 { get; set; }
        public DbSet<Db_eqc4Model> EqcDatas_eqc4 { get; set; }
        public DbSet<Db_eqc5Model> EqcDatas_eqc5 { get; set; }
        public DbSet<Db_eqc6Model> EqcDatas_eqc6 { get; set; }
        public DbSet<Db_eqc7Model> EqcDatas_eqc7 { get; set; }
        public DbSet<Db_eqc8Model> EqcDatas_eqc8 { get; set; }
        //OPEL
        public DbSet<Db_ArmrestFr> OpelArmrestFr_data { get; set; }
        public DbSet<Db_ArmrestRr> OpelArmrestRr_data { get; set; }


    }

}
