using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY
{
    public class LoginInfo
    {
        
    }

    public class ListTrainervm
    {
        public List<Trainervm> Lst { get; set; } = new List<Trainervm>();
    }
    public class Trainervm
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }


    public class ListModulevm
    {
        public List<Modulevm> Lst { get; set; } = new List<Modulevm>();
    }
    public class Modulevm
     {
         public long ID { get; set; }
         public string Module_Name { get; set; }
         public override string ToString()
         {
             return Module_Name;
         }
     }


    public class ListBatchvm
    {
        public List<Batchvm> Lst { get; set; } = new List<Batchvm>();

    }
    public class Batchvm
    {
        public long BatchID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long TrainerId { get; set; }
        public long TrainingModule { get; set; }
    }

    public class ListTraineevm
    {
        public List<Traineevm> Lst { get; set; } = new List<Traineevm>();
    }
    public class Traineevm
    {
        public long ID { get; set; }
        public string Name { get; set; }
    }

    public class AddTrainerinfo
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class AddModuleInfo
    {
        public long ID { get; set; }
        public string Module_Name { get; set; }
        public override string ToString()
        {
            return Module_Name;
        }
    }

    public class AddTraineeInfo
    {
        public long ID { get; set; }
        public string Name { get; set; }

    }

    public class AddBatchInfo
    {
        public long BatchID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long TrainerId { get; set; }
        public long TrainingModule { get; set; }

        public List<SelectListItem> TrNameLst { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> ModuleNameLst { get; set; } = new List<SelectListItem>();

    }


 
}