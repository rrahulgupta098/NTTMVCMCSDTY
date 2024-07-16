using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTTMVCMCSDTY
{
    public class DataAccessLayer
    {
        MVCMCSTYEntities ctx = new MVCMCSTYEntities();

        public bool Authenticate(string un, string pwd)
        {
            var res = (from obj in ctx.Login_Details
                       where obj.username == un && obj.password == pwd
                       select obj).FirstOrDefault();
            if (res != null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public List<Trainervm> GetTrainerData()
        {

            List<Trainervm> vm = new List<Trainervm>();
            try
            {
                var res = from obj in ctx.Trainer_Details
                      select obj;
         
                foreach (var rec in res)
                {
                Trainervm tvm = new Trainervm();
                tvm.ID = rec.TrainerID;
                tvm.Name = rec.Name;
                tvm.Skill = rec.Skill;
                vm.Add(tvm);
            }
        }

            catch (Exception)
            { 
            }
            return vm;
        }

       

        public List<Modulevm> GetModuleData()
         {
             List<Modulevm> mvm = new List<Modulevm>();
            try
            {
                var res = from obj in ctx.Training_Module_Details
                       select obj;
           
                foreach (var rec in res)
                {
                    Modulevm Module_mvm = new Modulevm();
                    Module_mvm.ID = rec.ModuleID;
                    Module_mvm.Module_Name = rec.Module_Name;
                    mvm.Add(Module_mvm);
                }
            }
            catch (Exception)
            { 
            }
             return mvm;
         }

        public List<Batchvm> GetBatchData()
        {
            List<Batchvm> vm = new List<Batchvm>();
            try
            {
                var res = from obj in ctx.Batch_Details
                          select obj;
                foreach (var rec in res)
                {
                    Batchvm bvm = new Batchvm();
                    bvm.BatchID = rec.BatchID;
                    bvm.StartDate = rec.StartDate;
                    bvm.EndDate = rec.EndDate;
                    bvm.TrainerId = rec.TrainerID;
                    bvm.EndDate = rec.EndDate;
                    bvm.TrainingModule = rec.TrainingModuleID;
                    vm.Add(bvm);
                }
            }
           catch (Exception) 
            {
            }
            return vm;
        }


        public List<Traineevm> GetTraineeData()
        {
            List<Traineevm> vm = new List<Traineevm>();
            try
            {
                var res = from obj in ctx.Trainee_Details
                          select obj;
                foreach (var rec in res)
                {
                    Traineevm tvm = new Traineevm();
                    tvm.ID = rec.TraineeID;
                    tvm.Name = rec.Name;
                    vm.Add(tvm);
                }
            }
            catch (Exception)
            {
            }
            return vm;
        }

        public bool Addtrainer(AddTrainerinfo tvm)
        {
            bool status = false;
            try
            {
                
                Trainer_Detail td = new Trainer_Detail();
                td.Name = tvm.Name;
                td.Skill = tvm.Skill;
                ctx.Trainer_Details.Add(td);
                ctx.SaveChanges();
                status = true;
                
            }
            catch(Exception)
            {

            }
            return status;
        }

        public bool AddModule(AddModuleInfo avm)
        {
            bool status = false;
            try
            {
            Training_Module_Detail tmd = new Training_Module_Detail();
            tmd.Module_Name = avm.Module_Name;
            ctx.Training_Module_Details.Add(tmd);
            ctx.SaveChanges();
            status = true;
            }
            catch (Exception)
            {

            }
            return status;
        }

        public bool Addtrainee(AddTraineeInfo model)
        {
            bool status = false;
            try
            {
            Trainee_Detail Td = new Trainee_Detail();
            Td.Name = model.Name;
            ctx.Trainee_Details.Add(Td);
            ctx.SaveChanges();
            status = true;
            }
            catch (Exception)
            {

            }
            return status;
        }


        public bool AddBatch(AddBatchInfo model)
        {
            bool status = false;
            try
            {
            Batch_Detail bd = new Batch_Detail();
            bd.StartDate = model.StartDate;
            bd.EndDate = model.EndDate;
            bd.TrainerID = model.TrainerId;
            bd.TrainingModuleID = model.TrainingModule;
            ctx.Batch_Details.Add(bd);
            ctx.SaveChanges();
            status = true;
            }
            catch (Exception)
            {

            }
            return status;
        }

        public List<AddTrainerinfo> GetTrainerName()
        {
            List<AddTrainerinfo> lst = new List<AddTrainerinfo>();
            try
            {
                var res = (from obj in ctx.Trainer_Details
                           select obj).ToList();
                foreach (var rec in res)
                {
                    AddTrainerinfo ati = new AddTrainerinfo();
                    ati.ID = rec.TrainerID;
                    ati.Name = rec.Name;
                    lst.Add(ati);
                }
            }
            catch (Exception) 
            {
            }
                return lst;
        }

        public List<AddModuleInfo> GetModuleName()
        {
            List<AddModuleInfo> lst1 = new List<AddModuleInfo>();
            try
            {
                var res = (from obj in ctx.Training_Module_Details
                           select obj).ToList();
                foreach (var rec in res)
                {
                    AddModuleInfo ami = new AddModuleInfo();
                    ami.ID = rec.ModuleID;
                    ami.Module_Name = rec.Module_Name;
                    lst1.Add(ami);
                }
            }
            catch (Exception)
            {

            }
            return lst1;
        }

        public void DeleteTrainer(long ID)
        {
            try
            {
                var trID = (from obj in ctx.Trainer_Details
                            where obj.TrainerID == ID
                            select obj).FirstOrDefault();

                if (trID != null)
                {

                    ctx.Trainer_Details.Remove(trID);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
        }

        public void DeleteModule(long ID)
        {
            try
            {
                var moId = (from obj in ctx.Training_Module_Details
                            where obj.ModuleID == ID
                            select obj).FirstOrDefault();

                if (moId != null)
                {
                    ctx.Training_Module_Details.Remove(moId);
                    ctx.SaveChanges();
                }
            }
            catch (Exception) 
            {
            }
        }



        public void DeleteTrainee(long ID)
        {
            try
            {
                var TId = (from obj in ctx.Trainee_Details
                           where obj.TraineeID == ID
                           select obj).FirstOrDefault();
                if (TId != null)
                {
                    ctx.Trainee_Details.Remove(TId);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
        }

        public void DeleteBatch(long ID)
        {
            try
            {
                var BId = (from obj in ctx.Batch_Details
                           where obj.BatchID == ID
                           select obj).FirstOrDefault();
                if (BId != null)
                {
                    ctx.Batch_Details.Remove(BId);
                    ctx.SaveChanges();
                }
            }
            catch (Exception) 
            { }
        }

        public Trainervm GetTrainerDetails(long ID)
        {
            Trainervm tinfo = null;
            var tobj = (from obj in ctx.Trainer_Details
                        where obj.TrainerID == ID
                        select obj).FirstOrDefault();

            if (tobj != null)
            {
                tinfo = new Trainervm();
                tinfo.ID = tobj.TrainerID;
                tinfo.Name = tobj.Name;
                tinfo.Skill = tobj.Skill;
            }
            return tinfo;
        }

       


        public bool EditTrainer(Trainervm tvm)
        {
            bool success = false;
            try
            {
                Trainer_Detail Tt = (from obj in ctx.Trainer_Details
                                     where obj.TrainerID == tvm.ID
                                     select obj).FirstOrDefault();
                if (Tt != null)
                {
                    Tt.Name = tvm.Name;
                    Tt.Skill = tvm.Skill;
                }
                ctx.SaveChanges();
                success = true;
            }
            catch (Exception) 
            {

            }
                return success;
        }

        
        public Modulevm GetModuleDetails(long ID)
        {
            Modulevm minfo = null;
            try
            {
                var mobj = (from obj in ctx.Training_Module_Details
                            where obj.ModuleID == ID
                            select obj).FirstOrDefault();
                if (mobj != null)
                {
                    minfo = new Modulevm();
                    minfo.ID = mobj.ModuleID;
                    minfo.Module_Name = mobj.Module_Name;
                }
            }
            catch (Exception)
            {

            }
            return minfo;
        }

       
        public bool EditModule(Modulevm mvm)
        {
            bool success = false;
            try
            {
                Training_Module_Detail Tm = (from obj in ctx.Training_Module_Details
                                             where obj.ModuleID == mvm.ID
                                             select obj).FirstOrDefault();
                if (Tm != null)
                {
                    Tm.Module_Name = mvm.Module_Name;
                }
                ctx.SaveChanges();
                success = true;
            } catch (Exception) 
            {
            }
            return success;
        }

        public Traineevm GetTraineeDetails(long ID)
        {
            Traineevm tinfo = null;
            try
            {
                var tobj = (from obj in ctx.Trainee_Details
                            where obj.TraineeID == ID
                            select obj).FirstOrDefault();
                if (tobj != null)
                {
                    tinfo = new Traineevm();
                    tinfo.ID = tobj.TraineeID;
                    tinfo.Name = tobj.Name;
                }
            }
            catch (Exception)
            {

            }
            return tinfo;
        }
        
        public bool EditTrainee(Traineevm tvm)
        {
            bool success = false;
            try
            {

                Trainee_Detail utn = (from obj in ctx.Trainee_Details
                                      where obj.TraineeID == tvm.ID
                                      select obj).FirstOrDefault();
                if (utn != null)
                {
                    utn.Name = tvm.Name;
                }
                ctx.SaveChanges();
                success = true;
            }
            catch (Exception)
            {
            }
            return success;
        }


    }
}