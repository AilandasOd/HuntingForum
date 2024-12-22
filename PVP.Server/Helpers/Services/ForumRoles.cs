namespace HForum.Server.Auth.Model
{
    public class ForumRoles
    {
        public const string Admin = nameof(Admin);
        public const string ForumUser = nameof(ForumUser);
        public const string Hunter = nameof(Hunter);

        public static readonly IReadOnlyCollection<string> All = new[] { Admin, ForumUser, Hunter };
    }
}
