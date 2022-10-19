namespace GenericFindMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindMaxNo findMaxNo = new FindMaxNo();
            findMaxNo.MaximumNum(100, 200, 300);

            MaximumNumber maximumNumber = new MaximumNumber();
            maximumNumber.MaximumNumber("vikas", "vikaaas", "vikaaaaaaas");

            FindMaxFloat findMaxfloat = new FindMaxFloat();
            findMaxfloat.MaximumFloat(8.1, 8.8, 7.6);
        }
    }
}