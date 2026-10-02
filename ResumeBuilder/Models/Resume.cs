using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Models
{
    public class Resume
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string LinkedIn { get; set; } = string.Empty;

        public string GitHub { get; set; } = string.Empty;

        public string AboutMe { get; set; } = string.Empty;

        public string Education { get; set; } = string.Empty;

        public string Experience { get; set; } = string.Empty;

        public string Internship { get; set; } = string.Empty;

        public string Projects { get; set; } = string.Empty;

        public string TechnicalSkills { get; set; } = string.Empty;

        public string SoftSkills { get; set; } = string.Empty;

        public string Certifications { get; set; } = string.Empty;
    }
}