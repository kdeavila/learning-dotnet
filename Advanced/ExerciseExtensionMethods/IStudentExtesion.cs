namespace ExerciseExtensionMethods.Extensions;

public static class StudentExtension
{
    public static bool HasIdAndCarnet(this IStudent student)
    {
        return !string.IsNullOrEmpty(student.Id) && student.HasCarnet;
    }
}
