package main;

import javax.swing.JFrame;

public class Game extends JFrame{
	
	public Game() {
		
		setSize(400, 400);
		setVisible(true);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		
	}

	public static void main(String[] args) {
		System.out.println("Start my TD Tut.");
		Game game = new Game();

	}


}