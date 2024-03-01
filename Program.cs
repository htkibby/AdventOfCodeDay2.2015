string filePath = System.IO.Path.GetFullPath("Dimensions.txt");
StreamReader dimensions = new(filePath);

string line = dimensions.ReadLine();
int totalSquareFeet = 0;
int totalPerimeter = 0;
int totalCubicVolume = 0;

while (line != null)
{
    string[] subs = line.Split('x', 3);
    int l = Int32.Parse(subs[0]);
    int w = Int32.Parse(subs[1]);
    int h = Int32.Parse(subs[2]);

    List<int> nums = [l, w, h];

    nums.Remove(nums.Max());
    int area = nums[0] * nums[1];

    int perrimeter = (nums[0] * 2) + (nums[1] * 2);
    totalPerimeter += perrimeter;

    int cubicVolume = l * w * h;
    totalCubicVolume += cubicVolume;

    int result = (2 * l * w) + (2 * w * h) + (2 * h * l) + area;
    totalSquareFeet += result;

    line = dimensions.ReadLine();
} 

Console.WriteLine($"Total Square Feet {totalSquareFeet}");
Console.WriteLine($"Total Permimeter {totalPerimeter}");
Console.WriteLine($"Total Volume {totalCubicVolume}");
Console.WriteLine($"Total Ribbon they will need {totalCubicVolume + totalPerimeter}");

