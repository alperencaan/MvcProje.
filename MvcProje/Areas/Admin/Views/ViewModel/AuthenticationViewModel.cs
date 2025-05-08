using Model.Entity;

namespace Model.ViewModels
{
    public class AuthenticationViewModel
    {
        public List<AboutDb> Abouts { get; set; }
        public List<ExperienceDb> Experiences { get; set; }
        public List<EducationDb> Educations { get; set; }
        public List<AbilityDb> Abilities { get; set; }
        public List<HobbyDb> Hobbies { get; set; }

        //burayada ekle
    }
}
