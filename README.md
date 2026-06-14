# ASG1_I3E_ShwunLeiWin_GameBuild
This is the 2nd repo for my ASG1 for I3E

# 🛒 1 Night At Guarian

A first-person supermarket survival and collection game built in Unity. Avoid the impatient customers, collect your items, and clock out before you lose your mind (and your job)!

---

## 🎮 How to Play & Run the Application

### ⚙️ Required Platforms & Settings
* **Platform:** PC / Mac (Runs inside the Unity Editor or via standalone build)
* **Input Devices:** Keyboard and Mouse

### ⌨️ Key Controls
* **WASD / Arrow Keys:** Move Player around the supermarket
* **Mouse Movement:** Look around / Pan camera view
* **Shift:** Sprint / Move faster

### 🤫 Game Hack & Debug Features
* **Developer Cheat:** If you want to instantly skip the collection phase for grading or testing purposes, you can manually adjust the `Items Collected` value to `13` inside the **GameManager** component in the Unity Inspector while the game is running, then walk straight to the Cashier Counter to trigger the Win state.

### 🧩 Puzzle Answer Key / Game Flow
1. Navigate the supermarket aisles while avoiding the proximity zones of moving customers.
2. Spot the grocery items that has fallen down from the shelves and move towards it to collect them! 
3. Keep an eye on the UI Text: you must collect exactly **13 items**. Entering customer zones will deplete your **Patience meter (starts at 5)**.
4. Once your counter reads `13 / 13`, navigate back to the **Cashier Counter** to successfully clear your shift and win the game.

---

## ⚠️ Known Limitations & Bugs
* **Camera Sensitivity:** Camera panning might feel stiff or slightly inverted depending on the monitor's refresh rate or mouse DPI settings.
* **Collider Clip:** Occasionally, moving customer models may clip slightly into aisle corner prefabs due to NavMesh pathing constraints. Your character can also clip into the shelves. (woops)

---

## 📜 References & Credits

### 🏗️ Assets & Packages
* **Character Controller & Inputs:** Unity Standard Assets / Starter Assets Package (First Person Character Capsule setup).
* **Text Rendering:** Unity TextMeshPro (TMP) package.

### 🎨 Models, Textures, & Materials
* **Supermarket Environment:** `[Insert Creator Name / Asset Store Pack Name here, e.g., "Free Low Poly Supermarket Pack by Kenney Assets"]`
* **Grocery Items & Props:** `[Low Poly Convenience Store By 9t5   https://assetstore.unity.com/packages/3d/props/9t5-low-poly-convenience-store-157383]`

* **Customer Models:** `[Low Poly People By David Jalbert    https://assetstore.unity.com/packages/3d/characters/humanoids/low-poly-people-by-david-jalbert-274814]`

### 🔊 Audio & Sound Effects
* **Item Collection "Ding" Sound:** `[from pixabay.com"]`
* **Customer "Excuse Me" Sound:** `[from pixabay.com"]`