using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class PTT_Manager:ISupplierService
    {
        //interface olan sınıfları çağırdık kurucu metodla atadık.
        private IApplicantServie _applicantServie;

        
        public PTT_Manager(IApplicantServie applicantServie) 
        {//kurucu metod
          //burada global olan değere applicantservice atadık.
            _applicantServie = applicantServie;
        }
        public void GiveMask(Person person)
        {
            
            if(_applicantServie.CheckPerson(person)) { 

                Console.WriteLine(person.First_Name+" " +
                    "için maske verildi.");

            }
        }
    }
}
