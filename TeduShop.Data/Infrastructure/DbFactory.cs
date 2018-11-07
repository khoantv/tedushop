namespace TeduShop.Data.Infrastructure
{
    /// <summary>
    /// Khởi tạo các đối tượng DBContext, thay vì khởi tạo trực tiếp đối tượng DBContext, ta sẽ khởi tạo thông qua DbFactory.
    /// </summary>
    public class DbFactory : Diposable, IDbFactory
    {
        private TeduShopDbContext dbContext;

        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext())
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}