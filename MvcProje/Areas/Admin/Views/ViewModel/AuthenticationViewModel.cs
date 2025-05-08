using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model.Entity;

namespace Model.ViewModels { 

  
           
        public class AuthenticationViewModel
        {
            public List<AboutDb> Abouts { get; set; }
            public List<ExperienceDb> Experiences { get; set; }
            public List<EducationDb> Educations { get; set; }
            public List<CertificateDb> Certificates { get; set; }  
            public List<ContactDb> Contacts { get; set; }
    }
    }


    //burayada ekl

