// See https://aka.ms/new-console-template for more information
Console.WriteLine("Global note calculation!");

int currentAssignments = 5;

int[] sophia = [93, 87, 98, 95, 100];
int[] nicolas = [80, 83, 82, 88, 85];
int[] zahirah = [84, 96, 73, 85, 79];
int[] jeong = [90, 92, 98, 100, 97];

int sophiaSum = sophia.Sum();
int nicolasSum = nicolas.Sum();
int zahirahSum = zahirah.Sum();
int jeongSum = jeong.Sum();

static string calculateNotes( int noteSum, int totalAssigments) {
  decimal mean = noteSum / totalAssigments;

  if (mean >= 97) return "A+";
  if (mean >= 93) return "A";
  if (mean >= 90) return "A-";
  if (mean >= 87) return "B+";
  if (mean >= 83) return "B";
  if (mean >= 80) return "B-";
  if (mean >= 77) return "C+";
  if (mean >= 73) return "C";
  if (mean >= 70) return "C-";

  return "C";
}

Console.WriteLine("Notes sophia:\t"  + calculateNotes(sophiaSum, currentAssignments));
Console.WriteLine("Notes nicolas:\t" + calculateNotes(nicolasSum, currentAssignments));
Console.WriteLine("Notes zahirah:\t" + calculateNotes(zahirahSum, currentAssignments));
Console.WriteLine("Notes jeong:\t"   + calculateNotes(jeongSum, currentAssignments));

// 97 - 100    A+
// 93 - 96     A
// 90 - 92     A-
// 87 - 89     B+
// 83 - 86     B