namespace GreenThumb.Model;

public class User
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }

    public static Boolean strongPassword(string password)
    {
        try {
        if (password.Length < 6 || password.Length > 12)
            throw new ArgumentException (paramName: nameof(password), message:"The password must be 6 to 12 characters long");

        } catch (ArgumentException e){
            Console.WriteLine(e);
        }

        try {
        if (!password.Any(c => char.IsDigit(c)))
            throw new ArgumentException (paramName: nameof(password), message:"The password must have at least one number");

        } catch (ArgumentException e){
            Console.WriteLine(e);

        }

        try {
        if (!password.Any(c => char.IsUpper(c)))
            throw new ArgumentException (paramName: nameof(password), message:"The password must have at least one uppercase character");

        } catch (ArgumentException e){
            Console.WriteLine(e);

        }

        try {
        if (!password.Any(c => char.IsLower(c)))
            throw new ArgumentException (paramName: nameof(password), message:"The password must have at least one lowercase character");

        } catch (ArgumentException e){
            Console.WriteLine(e);

        }

        try {
        if (!password.Any(c => char.IsSymbol(c)))
            throw new ArgumentException (paramName: nameof(password), message:"The password must have at least one special character");

        } catch (ArgumentException e){
            Console.WriteLine(e);

        }
        
        return true;
    }

}