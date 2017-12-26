using System.Data.Entity;

namespace NetOData.Models
{
    public partial class MySampleDb : DbContext
    {
        public MySampleDb() : base("name=MySampleDb")
        {
        }

        public virtual DbSet<AllianceData> AllianceDatas { get; set; }
        public virtual DbSet<Announce> Announces { get; set; }
        public virtual DbSet<Birthday> Birthdays { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyItem> SurveyItems { get; set; }
        public virtual DbSet<SurveyVote> SurveyVotes { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>()
                .Property(e => e.Content)
                .IsUnicode(false);
        }
    }
}
