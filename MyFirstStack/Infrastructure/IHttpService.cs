namespace MyFirstStack.Infrastructure
{
    public interface IHttpService<T>
    {
        // declarations of functions, but no definitions
        public T Get(string path);
    }
}
