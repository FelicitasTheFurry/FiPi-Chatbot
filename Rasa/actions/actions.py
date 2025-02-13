# This files contains your custom actions which can be used to run
# custom Python code.
#
# See this guide on how to implement these action:
# https://rasa.com/docs/rasa/custom-actions


# This is a simple example for a custom action which utters "Hello World!"
from typing import Any, Text, Dict, List
from rasa_sdk import Action, Tracker
from rasa_sdk.events import SessionStarted, ActionExecuted
from rasa_sdk.executor import CollectingDispatcher

class ActionSessionStart(Action):
    def name(self) -> Text:
        return "action_session_start"

    async def run(
        self, dispatcher: CollectingDispatcher, tracker: Tracker, domain: Dict[Text, Any]
    ) -> List[Dict[Text, Any]]:
        # Neue Session initialisieren
        events = [SessionStarted()]
        
        # Begrüßungsnachricht senden (verwende hier dein Template aus domain.yml)
        dispatcher.utter_message(response="utter_greet")
        
        # Den Bot wieder in den Zuhörmodus versetzen
        events.append(ActionExecuted("action_listen"))
        return events