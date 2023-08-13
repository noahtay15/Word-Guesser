using System;
using System.IO;
using System.Linq;

internal class FileHandler
{
	private string[,] cities;
    private string[,] fruits;
    private string[,] sports;
    private string[,] drinks;
    private string[,] animals;
    private int numQuestionsPerCat;

    public FileHandler(string citiesFilePath, string flowersFilePath, string sportsFilePath, string drinksFilePath, string animalsFilePath, int numQuestionsPerCat)
	{
		try
		{
            this.cities = createQuestionsArray(citiesFilePath);
            this.fruits = createQuestionsArray(flowersFilePath);
            this.sports = createQuestionsArray(sportsFilePath);
            this.drinks = createQuestionsArray(drinksFilePath);
            this.animals = createQuestionsArray(animalsFilePath);
            this.numQuestionsPerCat = numQuestionsPerCat;
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("A file is missing. Make sure you have downloaded all the correct files.\n" + ex.Message);
        } 
        catch (IOException ex)
        {
            Console.WriteLine("An IO error has occured. Make sure you have downloaded all the correct files.\n" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexcpected error has occured.\n" + ex.Message);
        }
	}

    private string[,] createQuestionsArray(string filePath)
    {
        string[] fileLines = File.ReadAllLines(filePath); //to read in the lines. Should look like this answer:hint
        int[] randedNums = new int[4]; //the array that holds the indexes to pull from fileLines 
        Random rand = new Random();
        int randNum;
        for (int i = 0; i < 4; i++)  //fills in randedNums with the actual indexes
        {
            randNum = rand.Next(0, 15);
            if (!randedNums.Contains(randNum))
            {
                randedNums[i] = randNum;
            }
            else
            {
                i--;
            }
        }
        string[,] array = new string[randedNums.Length, 2]; //the array to be returned 
        for(int i = 0; i < randedNums.Length; i++)
        {
            /**
             * loops through randedNums and takes the stored random int (which is the selected index for the question:hint in fileLines)
             * and splits them apart to be put into the final returning array
             */
            string[] temp2 = fileLines[randedNums[i]].Split(':'); 
            array[i, 0] = temp2[0].Trim();
            array[i, 1] = temp2[1].Trim();
        }
        return array;
    }

    public string[,] getCities() { return cities;}
    public string[,] getFruits() { return fruits;}
    public string[,] getAnimals() { return animals;}
    public string[,] getDrinks() { return drinks;}
    public string[,] getSports() { return sports;}
}
