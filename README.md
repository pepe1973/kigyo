# Szinti Snake Competition

This project was created as the starting point of a coding game and competition hosted by Synthesis-Net LLC.

## The goal

The game is played in an arena, where two individual snakes fight for points by finding apples. The one, which has more points at the end of the round, or survived longer is the winner. The goal of the competitors is to build a snake brain, which can navigate through different arena layouts, collect more apples, points and powerups, and outsmart the opponent.
For more information about the deadlines, entry and solution submit please refer to the competition announcement at https://szintisnake2021.ticketninja.io/

## Questions
For techincal questions, submit a question on the [Discussions page](https://github.com/szintisnake/szinti-snake-competition/discussions)

## Basic concepts

### Apples 🍎
An apple displays at random times at random places in the game field. Their frequency of appearance, lifetime and score can vary between arenas.

### PowerUps 🎁
Powerup boxes also display at random time intervals on the field. Their frequency of appearance, lifetime, score and content probability can vary between arenas.

_(As an example, Simple.arena is setup with powerups. Please check the .arena xml file for details)_

### Available PowerUps
* **NoWall** ⛏️: Pass through 1 block of wall. Passive - is simply used when available and passing through a wall.
* **Reverse** 🔃: Turn snake around (tail and head are exchanged). Also steps forward into the returned direction. Active - need to be activated.
* **Diagonal** ↝: Snake can take a diagonal step. Active - need to activate the powerup with a secondary direction.

### Rules
* Powerups can be used only for a specific amount (Usage). When it reaches 0 the powerup cannot be used anymore.
* Snakes can have multiple powerups but they can have only 1 from each different type.
* Snakes can pick up a powerup with the same type they already have, in this case the powerup Usage set back to maximum (they do not stack!). The point for picking it up is sumbitted of course.
* Passive powerups used up automatically when they are needed. (i.e. when hitting a wall)
* Active powerups need to be activated by Snakes (safety measures need to be handled by powerup owners).
* Powerups are lost when round ends or when game ends.

### Time limits ⏱️
This year, to motivate efficiency, we introduced time limits on arenas. The timing works like a chess clock - each snakes have a given amount of time they can use for thinking. If the time runs up for a snake, it loses the round - so think faster than your opponent does!

## TestForm's UI
- you can change the players "brain" by clinking on their name and load a valid brain dll.
- cyou an change the arena by clicking on "Playground" link and load a valid .arena file.
- you can change speed of the game by modifying the fps slider
- when a round ends, you can do a replay of the last 256 steps by clicking on the Replay link

## Repository structure

### Arena

Each file describes the layout of an arena where the snakes are fighting for survival.

### Demo

A fully functional demo, with arenas, template brains and a snake tester app.

### Lib

Template snake brains and the core library (SnakeLib.dll), which contains a handful of properties and methods to control the snakes.

### Src

A solution with two projects to start coding:
- SnakeTester: the main application, which loads the selected snakes into the selected arena. Look into TestForm.TestForm_Load() to see how to configure it.
- TemplateBrain: a template project, which demonstrates how a snake brain implementation looks like.
