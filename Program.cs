string filePath = System.IO.Path.GetFullPath("Dimensions.txt");
StreamReader dimensions = new(filePath);

string line = dimensions.ReadLine();
int totalSquareFeet = 0;

while (line != null)
{
    string[] subs = line.Split('x', 3);
    int l = Int32.Parse(subs[0]);
    int w = Int32.Parse(subs[1]);
    int h = Int32.Parse(subs[2]);

    List<int> nums = [l, w, h];
    nums.Remove(nums.Max());
    int area = nums[0] * nums[1];

    int result = (2 * l * w) + (2 * w * h) + (2 * h * l) + area;
    totalSquareFeet += result;

    line = dimensions.ReadLine();
} 

Console.WriteLine(totalSquareFeet);

