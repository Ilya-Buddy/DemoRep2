Random rnd = new Random();
int count = rnd.Next(20, 21);
string str = string.Empty;
int r;
char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+{}|".ToCharArray();
for (int i = 0; i < count; i++) {
    r = rnd.Next(chars.Length);
    str += chars[r];
}

Console.WriteLine(str);





