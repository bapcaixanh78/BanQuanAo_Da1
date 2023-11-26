using DAL.Mydbcontext;

ShopDbcontext shopDbcontext = new ShopDbcontext();
for(int i = 0; i < shopDbcontext.Chitietsanphams.ToList().Count; i++)
{
    Console.WriteLine(shopDbcontext.Chitietsanphams.ToList().Count);
}