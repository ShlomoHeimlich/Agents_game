🎯 משחק חשיפת סוכנים
🕹️ תיאור המשחק
במשחק הזה המטרה היא לחשוף סוכן על ידי גילוי כל המכשירים שלו.

לכל סוכן יש:

שם (string)

דרגת STR (מספר שלם)

מילון של מכשירים – שבו:

המפתח הוא שם המכשיר (string)

הערך הוא כמות המכשירים מסוג זה (int)

כדי לחשוף את הסוכן – יש לגלות את כל המכשירים שלו. רק כאשר הכמות של כל המכשירים מגיעה ל־0, הסוכן נחשב כחשוף.

🧱 מבנה המחלקות
Agent (סוכן)
python
Copy
Edit
class Agent:
    def __init__(self, name: str, str_level: int, devices: dict):
        self.name = name
        self.str_level = str_level
        self.devices = devices  # {'שם מכשיר': כמות}

    def reveal_device(self, device_name: str) -> str:
        if device_name in self.devices and self.devices[device_name] > 0:
            self.devices[device_name] -= 1
            remaining = self.devices[device_name]
            return f"{device_name} נמצא. נותרו {remaining} לחשיפה."
        else:
            return "המכשיר לא נמצא אצל הסוכן"
Device (מכשיר)
python
Copy
Edit
class Device:
    def __init__(self, name: str):
        self.name = name
🧠 מהלך המשחק
מנהל המשחק מגדיר כמה מכשירים יש לחשוף בסך הכול.

המשתמש מקליד שמות של מכשירים.

אם המכשיר קיים אצל הסוכן:

יורדת הכמות של אותו מכשיר ב־1.

מוצג כמה מכשירים כאלה נותרו.

אם המכשיר לא קיים:

מוצג ההודעה: "המכשיר לא נמצא אצל הסוכן"

✅ בדיקת חשיפת סוכן
אפשר לבדוק אם הסוכן נחשף כך:

python
Copy
Edit
def is_exposed(agent: Agent) -> bool:
    return all(count == 0 for count in agent.devices.values())
🧪 דוגמה
python
Copy
Edit
agent = Agent("צֶל", 5, {
    "באג": 2,
    "מצלמה": 1,
    "משדר": 3
})

print(agent.reveal_device("מצלמה"))     # מצלמה נמצא. נותרו 0 לחשיפה.
print(agent.reveal_device("עט לייזר"))  # המכשיר לא נמצא אצל הסוכן
