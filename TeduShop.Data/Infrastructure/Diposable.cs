using System;

namespace TeduShop.Data.Infrastructure
{
    /// <summary>
    /// Cho phép các class kế thừa nó kế thừa các phương thức tự động hủy.
    /// Tự động hủy các đối tượng khi không dùng đến.
    /// </summary>
    public class Diposable : IDisposable
    {
        private bool isDisposed;

        ~Diposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
        }

        protected virtual void DisposeCore()
        {
        }
    }
}