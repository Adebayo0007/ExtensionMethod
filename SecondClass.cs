public static class SecondClass
{
         public static string NumberOfWords(this String prog)
        {
            if(!(string.IsNullOrWhiteSpace(prog)))
            {
            var result = prog.Split(" ");
            var y = result.Count().ToString();
            return y;
            }
            return null;
        }

}