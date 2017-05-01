namespace Net.Chdk.Validators
{
    public interface IValidator<T>
    {
        void Validate(T value, string basePath);
    }
}
