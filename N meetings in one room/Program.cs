using N_meetings_in_one_room;

Solution solution = new();
Console.WriteLine(solution.MaxMeetings(6, [1, 3, 0, 5, 8, 5], [2, 4, 6, 7, 9, 9]));
Console.WriteLine(solution.MaxMeetings(3, [10, 12, 20], [20, 25, 30]));
Console.WriteLine(solution.MaxMeetings(8,[75250, 50074, 43659, 8931, 11273, 27545, 50879, 77924],
[112960, 114515, 81825, 93424, 54316, 35533, 73383, 160252]));
