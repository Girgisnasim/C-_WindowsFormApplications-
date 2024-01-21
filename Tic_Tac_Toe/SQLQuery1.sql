create database Tic_Tac_Toe;
use Tic_Tac_Toe;

create table usersScores(
	ID int primary key identity,
    PlayerOneName varchar(50),
	ScorePlayerOne int,
    PlayerTwoName varchar(50),
    ScorePlayerTwo int
);