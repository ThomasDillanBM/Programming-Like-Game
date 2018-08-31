﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileForm : MonoBehaviour 
{

	public enum ConditionOperator{MoreThan, LessThan, MoreThanEquals, LessThanEquals, Equals, Different}

	public Expression mainExpression;
	public string Corpus;
	public Queue<Command> commands;

	public WhileForm ()
	{
		mainExpression = new Expression ();
		Corpus = "";
		commands = new Queue<Command> ();
	}

}
