using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MIS2019
{
    public class PacientDBContext : DbContext
    {
        public DbSet<Pacient> pacients { get; set; }
        public DbSet<Anamnesis> anamneses { get; set; }
        public DbSet<Diagnosis> diagnoses { get; set; }
        public DbSet<DiagnosisType> diagnosisTypes { get; set; }

        public DbSet<VisitDate> visits { get; set; }


    }

}