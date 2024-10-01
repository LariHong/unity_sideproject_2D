
## OnDrawGizmos（繪製場景小工具）

`OnDrawGizmos` 是 Unity 中用來在 Scene 視窗中繪製調試圖形的函數。它對遊戲物體在場景中的展示不會影響遊戲本身的邏輯或視覺效果，只會在編輯器的 Scene 視窗中出現，主要用於幫助開發者在場景中視覺化某些數據或邏輯。

### 1. **基本使用**
   - **功能**: 
     - 在場景視窗中繪製可視化的幾何圖形（如球體、立方體、射線等），通常用來展示範圍、碰撞檢測區域或其他需要視覺化的數據。
   
   - **內部機制**:
     - `OnDrawGizmos` 是 Unity 編輯器專用的函數，在編輯器的 Scene 視窗中自動被調用，但在運行時不會調用。
     - 開發者可以透過 `Gizmos` 類來使用內建的繪製方法，例如 `Gizmos.DrawSphere()`、`Gizmos.DrawLine()` 等。

### 2. **常用繪製方法**
   - **Gizmos.DrawSphere(Vector3 center, float radius)**:
     - 在 `center` 位置繪製一個指定半徑的球體。
     - **用途**: 通常用來表示觸發區域、敵人感應範圍等。
     - **內部機制**: 繪製的球體僅在 Scene 視窗中可見，不會影響實際遊戲中物體的碰撞或物理效果。

   - **Gizmos.DrawCube(Vector3 center, Vector3 size)**:
     - 在 `center` 位置繪製一個指定大小的立方體。
     - **用途**: 可以用來顯示碰撞盒或攻擊範圍。
     - **內部機制**: 同樣，這些繪製內容只會出現在 Scene 視窗，不會出現在遊戲運行時的畫面中。

   - **Gizmos.DrawLine(Vector3 from, Vector3 to)**:
     - 從 `from` 點畫一條線到 `to` 點。
     - **用途**: 用來表示路徑、方向或連接兩個物體的關係。
     - **內部機制**: 這些線段在 Scene 視窗中是靜態顯示，通常用於指示方向或範圍，便於場景布局的規劃。

   - **Gizmos.color**:
     - 設定 Gizmos 的繪製顏色。例如，`Gizmos.color = Color.red` 會讓後續繪製的圖形顯示為紅色。
     - **用途**: 區分不同類型的範圍或物體（例如，紅色表示危險區域，綠色表示安全區域）。
     - **內部機制**: `Gizmos.color` 不影響遊戲中的物體顏色，只影響 Scene 視窗中的 Gizmos 繪製。

### 3. **OnDrawGizmos 和 OnDrawGizmosSelected 的區別**
   - **OnDrawGizmos**:
     - 無論是否選中該物體，只要進入 Scene 視窗，Gizmos 就會顯示。
   
   - **OnDrawGizmosSelected**:
     - 僅當選中該物體時，才會顯示該物體的 Gizmos。
   
   - **內部機制**: 使用 `OnDrawGizmosSelected` 可以避免場景中顯示過多的 Gizmos，只在調試該物體時展示，減少視覺干擾。

