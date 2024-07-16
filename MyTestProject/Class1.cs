using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NTTMVCMCSDTY;
using NTTMVCMCSDTY.Controllers;
using System.Web.Mvc;

namespace MyTestProject
{

    public class Class1
    {
      [Fact]
        public void TestDataAccess_Proj()
        {
            Trainer_DetailsController ctrl = new Trainer_DetailsController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
        public void TestDataAccess_Proj1()
        {
            Training_Module_DetailsController ctrl = new Training_Module_DetailsController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
        public void TestDataAccess_Proj2()
        {
            BatchController ctrl = new BatchController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
        public void TestDataAccess_Proj3()
        {
            Trainee_DetailsController ctrl = new Trainee_DetailsController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
        public void TestDataAccess_Proj4()
        {
            Add_TrainerController ctrl = new Add_TrainerController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
        public void TestDataAccess_Proj5()
        {
            Add_Training_ModuleController ctrl = new Add_Training_ModuleController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
        public void TestDataAccess_Proj6()
        {
            Add_BatchController ctrl = new Add_BatchController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
        public void TestDataAccess_Proj7()
        {
            Add_TraineeController ctrl = new Add_TraineeController();
            ActionResult ar = ctrl.Index();
            Assert.NotNull(ar);
        }

        [Fact]
       public void TestDBAccess_Project()
       {
           DataAccessLayer dal = new DataAccessLayer();
           var Lst = dal.GetTrainerData();
            Assert.NotNull(Lst);   
       }

        [Fact]
        public void TestDBAccess_Project1()
        {
            DataAccessLayer dal = new DataAccessLayer();
            var Lst = dal.GetModuleData();
            Assert.NotNull(Lst);
        }

        [Fact]
        public void TestDBAccess_Project2()
        {
            DataAccessLayer dal = new DataAccessLayer();
            var Lst = dal.GetBatchData();
            Assert.NotNull(Lst);
        }
        
        [Fact]
        public void TestDBAccess_Project3()
        {
            DataAccessLayer dal = new DataAccessLayer();
            var Lst = dal.GetTraineeData();
            Assert.NotNull(Lst);
        }

        [Fact]
        public void TestDBAccess_Project4()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddTrainerinfo obj = new AddTrainerinfo();
            var Lst = dal.Addtrainer(obj);
        }

        [Fact]
        public void TestDBAccess_Project5()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddModuleInfo obj = new AddModuleInfo();
            var Lst = dal.AddModule(obj);
        }

        [Fact]
        public void TestDBAccess_Project6()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddBatchInfo obj = new AddBatchInfo();
            var Lst = dal.AddBatch(obj);
        }

        [Fact]
        public void TestDBAccess_Project7()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddTraineeInfo obj = new AddTraineeInfo();
            var Lst = dal.Addtrainee(obj);
        }

        [Fact]
        public void TestDBAccess_Project8()
        {
            DataAccessLayer dal = new DataAccessLayer();
            var Lst = dal.GetTrainerName();
            Assert.NotNull(Lst);
        }

        [Fact]
        public void TestDBAccess_Project9()
        {
            DataAccessLayer dal = new DataAccessLayer();
            var Lst = dal.GetModuleName();
            Assert.NotNull(Lst);
        }

        [Fact]
        public void TestDBAccess_Project10()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Trainervm obj = new Trainervm();
            obj.ID = 1;
           // obj.Name = "jh";
            //obj.Skill = "C#";
            bool ar = dal.EditTrainer(obj);
            Assert.False(ar);
        }

        [Fact]
        public void TestDBAccess_Project11()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Modulevm obj = new Modulevm();
            obj.ID = 1;
            // obj.Name = "jh";
            //obj.Skill = "C#";
            bool ar = dal.EditModule(obj);
            Assert.False(ar);
        }

        [Fact]
        public void TestDBAccess_Project12()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Traineevm obj = new Traineevm();
            obj.ID = 1;
            // obj.Name = "jh";
            //obj.Skill = "C#";
            bool ar = dal.EditTrainee(obj);
            Assert.False(ar);
        }


        [Fact]
        public void TestDBAccess_Project13()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Trainervm obj = new Trainervm();
            obj.ID = 1;
            // obj.Name = "jh";
            //obj.Skill = "C#";
            // var ar = dal.DeleteTrainer();
            dal.DeleteTrainer(obj.ID);
         // Assert.NotNull(a);
        }


        [Fact]
        public void TestDBAccess_Project14()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Modulevm obj = new Modulevm();
            obj.ID = 1;
            // obj.Name = "jh";
            //obj.Skill = "C#";
            // var ar = dal.DeleteTrainer();
            dal.DeleteModule(obj.ID);
            // Assert.NotNull(a);
        }

        [Fact]
        public void TestDBAccess_Project15()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Traineevm obj = new Traineevm();
            obj.ID = 1;
            // obj.Name = "jh";
            //obj.Skill = "C#";
            // var ar = dal.DeleteTrainer();
            dal.DeleteTrainee(obj.ID);
            // Assert.NotNull(a);
        }

        [Fact]
        public void TestDBAccess_Project16()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Batchvm obj = new Batchvm();
            obj.BatchID = 1;
            // obj.Name = "jh";
            //obj.Skill = "C#";
            // var ar = dal.DeleteTrainer();
            dal.DeleteBatch(obj.BatchID);
            // Assert.NotNull(a);
        }
       

    }
}
