﻿public class Manager : Singleton<Manager> {
	protected Manager () {} // guarantee this will be always a singleton only - can't use the constructor!
	
	public bool isPlayerOnStage;
}