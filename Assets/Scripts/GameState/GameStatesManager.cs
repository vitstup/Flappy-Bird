using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameStatesManager : MonoBehaviour
{
    public GameState currentState { get; private set; }

	private Dictionary<Type, GameState> registeredStates = new Dictionary<Type, GameState>();

    [Inject] DiContainer container;

	private void Start()
	{
		RegisterStates();

        ChangeState(typeof(NewGameState));
	}
    
    private void RegisterStates()
    {
        RegisterState(new NewGameState());
        RegisterState(new PlayingState());
        RegisterState(new PausedState());
        RegisterState(new LostState());
    }

	private void RegisterState(GameState state)
    {
        Type type = state.GetType();

        if (registeredStates.ContainsKey(type)) 
        {
            throw new Exception("Already contains this state");
        }
        else
        {
            registeredStates.Add(type, state);
            container.Inject(state);
        }
    }

    public void ChangeState(Type type)
    {
		if (registeredStates.ContainsKey(type))
        {
            ChangeState(registeredStates[type]);
        }
        else
        {
			throw new Exception("Theare is no such state in dictionary");
		}
	}

	private void ChangeState(GameState state)
    {
        currentState?.OnExited();

        currentState = state;

        currentState?.OnEntered();
    }
}