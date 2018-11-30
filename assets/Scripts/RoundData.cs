using UnityEngine;
using System.Collections;

[System.Serializable]
public class RoundData
{
    public string name;
    public int timeLimitInSeconds;
    public int pointsAddedForOneAnswer;
    public int pointsAddedForTwoAnswer;
    public int pointsAddedForThreeAnswer;
    public int pointsAddedForFourAnswer;
    public int pointsAddedForFiveAnswer;
    public int pointsAddedForSixAnswer;
    public QuestionData[] questions;

}
