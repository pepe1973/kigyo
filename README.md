# Szinti Snake Competition

This project was created as the starting point of a coding game and competition hosted by Synthesis-Net LLC.

## The goal

The game is played in an arena, where two individual snakes fight for points by finding apples. The one, which has more points at the end of the round, or survived longer is the winner. The goal of the competitors is to build a snake brain, which can navigate through different arena layouts, collect more apples and points, and outsmart the opponent.
For more information about the deadlines, entry and solution submit please refer to the competition announcement at https://szintisnake.ticketninja.io/

## Questions
For techincal questions, submit an issue.

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
