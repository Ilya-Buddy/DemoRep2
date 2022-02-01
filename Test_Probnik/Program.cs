Random rnd = new Random();
int count = rnd.Next(10, 11);
string password = string.Empty;
int r;
char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+{}|".ToCharArray();
for (int i = 0; i < count; i++) 
{
    r = rnd.Next(chars.Length);
    password += chars[r];
}

Console.WriteLine(password);
