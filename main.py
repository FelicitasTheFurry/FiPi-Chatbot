import json
import spacy
import random
from sklearn.feature_extraction.text import CountVectorizer
from sklearn.ensemble import RandomForestClassifier
from sklearn.pipeline import Pipeline
from sklearn.preprocessing import MultiLabelBinarizer
from sklearn.multiclass import OneVsRestClassifier
from sklearn.model_selection import train_test_split

# NLP-Modell laden
nlp = spacy.load("de_core_news_sm")

def preprocess_text(text):
    doc = nlp(text.lower())
    return " ".join([token.lemma_ for token in doc if not token.is_stop and token.is_alpha])

# Daten aus externer JSON-Datei laden
def load_data(filename="datenbank.json"):
    with open(filename, "r") as f:
        return json.load(f)

data = load_data()

# Trainingsdaten vorbereiten
X = []
y = []
all_labels = set()
for intent in data["intents"]:
    for frage in intent["fragen"]:
        X.append(preprocess_text(frage))
        y.append(intent["intent"])
        all_labels.update(intent["intent"])

# MultiLabel-Binarizer für Multi-Label-Klassifikation
mlb = MultiLabelBinarizer()
y_bin = mlb.fit_transform(y)

# Daten in Trainings- und Testset aufteilen (80/20)
X_train, X_test, y_train_bin, y_test_bin = train_test_split(X, y_bin, test_size=0.2, random_state=88)

# Pipeline mit Vektorisierung + Multi-Label-Klassifikator
pipeline = Pipeline([
    ("vectorizer", CountVectorizer()),
    ("classifier", OneVsRestClassifier(RandomForestClassifier(n_estimators=10)))
])

# Trainieren des Modells
pipeline.fit(X_train, y_train_bin)

def get_intents(frage):
    frage_preprocessed = preprocess_text(frage)
    predictions = pipeline.predict([frage_preprocessed])
    predicted_labels = mlb.inverse_transform(predictions)
    return predicted_labels[0] if predicted_labels else []

def get_answer(frage):
    intents = get_intents(frage)
    responses = []
    for item in data["intents"]:
        if set(item["intent"]).intersection(set(intents)):
            responses.append(item["antwort"].format(date="10.02.2025", subjects="Mathe, Deutsch", teacher="Max Mustermann", subject="LF-10", year="2. Ausbildungsjahr"))
    return " \n".join(responses) if responses else "Ich habe leider keine Antwort darauf."

# Test
while True:
    user_input = input("Du: ")
    if user_input.lower() in ["exit", "quit"]:
        break
    print("Bot:", get_answer(user_input))