# AdventOfCode
Base .NET Core project for Advent Of Code solutions

## To use

Each day's solution will be implemented in the `Solution` class located in each day's respective folder.  The "day" integer property has already been filled out since that is known ahead of time, you will have to fill in the "title" since that is unknown until the day of. Each solution has two parts (methods) and they will return a string.

Solution inputs are in the Resources.resx file, the keys are already there just replace the value with your own input.  The `BaseSolution` abstract class has a `GetResourceString()` method that will return the input as a string for you.

To run, just run the `AdventOfCode.SolutionRunner`.  By default this will iterate through all 25 days, but the repository has a method to get a specific day.  The `.ToString()` method of the solution will give both parts of the solution for each day (or displaying nothing if the solution has not been implemented).

I have also included a README sample that allows you to quickly link to the question and the answer in your repo.  Maintenence is required every year, you will have to update the year in the links but the Github paths are relative and _should_ work if you keep the same solution structure as this project.
