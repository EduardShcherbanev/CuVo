using System;
using CuVo.Models.Learning;
using CuVo.Models.User;
using CuVo.Models.Vocabulary;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CuVo.DBRepository.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Authenticated UserId
        /// </summary>
        public string UserId { get; set; }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<UserWord> UserWords { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Translation>().HasKey(c => new { c.UserWordFromId, c.UserWordToId });
            builder.Entity<Word>().HasIndex(u => new { u.Spelling, u.LanguageId }).IsUnique();
            builder.Entity<UserWord>().HasIndex(c => new { c.UserId, c.WordId });
        }
    }
}
