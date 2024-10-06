# Unity Time 類別 詳細解釋

## Time 類別概述
Unity 的 `Time` 類別用來管理遊戲中的時間相關功能。它允許開發者獲取遊戲運行的時間、控制時間縮放、以及計算兩幀之間的時間差等。這對於控制遊戲的節奏、管理動畫、物理運動等至關重要。

## 1. `deltaTime` 和 `fixedDeltaTime`

### `deltaTime` 概述
`Time.deltaTime` 代表上一幀渲染所花費的時間，這在處理基於時間的動畫或物理運算時非常有用。它是以秒為單位，並隨著每一幀的變化而更新。

### `fixedDeltaTime` 概述
`Time.fixedDeltaTime` 是用來表示每次物理更新之間的固定時間間隔。物理運算是基於固定時間步驟進行的，因此 `fixedDeltaTime` 通常在物理模擬和剛體運算中使用。

### 內部機制
- `deltaTime` 在每一幀渲染結束後進行更新，該值是通過計算當前幀與上一幀之間的時間差得出。
- `fixedDeltaTime` 則是由 Unity 的物理引擎控制，它不會根據遊戲運行時的幀率變化而改變，確保了物理模擬的一致性。

---

## 2. `timeScale`

### 概述
`Time.timeScale` 是控制遊戲時間的縮放比例。當 `timeScale` 設置為 1 時，時間以正常速度運行；當設置為 0 時，遊戲時間會完全暫停；當設置為 0.5 時，遊戲時間以正常速度的一半運行。

### 內部機制
- 當 `timeScale` 發生變化時，Unity 會動態調整所有基於時間的更新，例如動畫、物理模擬、以及所有依賴 `deltaTime` 和 `fixedDeltaTime` 的運算。
- 需要注意的是，`timeScale` 不會影響 `fixedDeltaTime`，因此物理模擬依然按照固定的步驟運行，即使遊戲的其他部分時間縮放了。

### 使用場景
`timeScale` 常用於實現 **慢動作** 或 **暫停遊戲** 的效果。例如，當遊戲玩家進入「子彈時間」模式時，可以將 `timeScale` 設置為 0.2，使得一切動作都變得非常緩慢。

---

## 3. `time` 和 `realtimeSinceStartup`

### `time` 概述
`Time.time` 是從遊戲開始到當前時間所經過的秒數，並且該值會受到 `timeScale` 的影響。

### `realtimeSinceStartup` 概述
`Time.realtimeSinceStartup` 則是從遊戲啟動後所經過的實際時間（以秒為單位），並且不受 `timeScale` 的影響。

### 內部機制
- `Time.time` 是基於遊戲內部的時間流動計算出來的，因此任何對 `timeScale` 的更改都會影響到這個值。
- `Time.realtimeSinceStartup` 直接反映了遊戲運行的真實世界時間，它依賴系統的時鐘來更新，而不是遊戲內的時間系統，因此不受遊戲內時間縮放的影響。

### 使用場景
`realtimeSinceStartup` 經常用於計算與遊戲內時間無關的現實時間，例如顯示總運行時間、控制UI的延遲等。

---

## 4. `unscaledTime` 和 `unscaledDeltaTime`

### `unscaledTime` 概述
`Time.unscaledTime` 是遊戲開始後的時間，不會受到 `timeScale` 的影響。即使時間縮放為 0（遊戲暫停），`unscaledTime` 仍會繼續增加。

### `unscaledDeltaTime` 概述
`Time.unscaledDeltaTime` 則表示上一幀與當前幀之間的時間差，也不受 `timeScale` 的影響。這對於需要在遊戲暫停時進行的操作（如 UI 更新、音頻處理）非常有用。

### 內部機制
- `unscaledTime` 和 `unscaledDeltaTime` 都依賴於 Unity 的內部時鐘，不受遊戲時間的控制，並且會在每幀進行更新。
- 當 `timeScale` 設置為 0 時，`deltaTime` 會變為 0，但 `unscaledDeltaTime` 仍然持續計算。

### 使用場景
`unscaledTime` 和 `unscaledDeltaTime` 通常用於在遊戲暫停時進行 UI 動畫或其他需要不間斷運行的系統。例如，遊戲暫停時，某些 UI 元素可能需要繼續動畫，而不會因為 `timeScale` 為 0 而停止。

---

## 5. `fixedTime`

### 概述
`Time.fixedTime` 是物理系統中的時間軸，該值會在每次物理更新時遞增。與 `Time.time` 相似，但它是基於 `fixedDeltaTime` 進行計算的。

### 內部機制
`fixedTime` 代表物理模擬中的時間進程，這個值在每次物理更新中會加上 `fixedDeltaTime`，因此它是離散遞增的。這對於與物理相關的計算非常重要，因為這些計算必須依賴於固定的時間步驟來保證一致性。

### 使用場景
`fixedTime` 在處理與物理模擬相關的邏輯時非常有用，比如需要與物理更新同步的動畫或特效。

---

## 6. `smoothDeltaTime`

### 概述
`Time.smoothDeltaTime` 是 `deltaTime` 的平滑版本，它通過過濾來消除幀率的突然波動，從而提供更平穩的時間步長。

### 內部機制
Unity 通過內部的平滑算法（類似於移動平均）來計算 `smoothDeltaTime`，這使得即使幀率波動較大，遊戲的更新也能保持相對平穩。

### 使用場景
`smoothDeltaTime` 經常用於動畫或相機平移，這些場景下不希望因為幀率變化而導致運動的突然跳動。

---

## 7. `frameCount`

### 概述
`Time.frameCount` 返回從遊戲開始以來已經渲染的幀數。

### 內部機制
Unity 內部會在每次渲染幀數時自動遞增這個值，並且它不會受到 `timeScale` 的影響。

### 使用場景
`frameCount` 通常用於優化和調試，開發者可以用它來計算每幀之間的差異，從而判斷性能表現。

---

## 8. `maximumDeltaTime`

### 概述
`Time.maximumDeltaTime` 用於限制 `deltaTime` 的最大值，這對於防止在幀率過低時遊戲中的計算量過大很有幫助。

### 內部機制
Unity 會將每一幀的 `deltaTime` 與 `maximumDeltaTime` 進行比較，並確保 `deltaTime` 不會超過這個限制。這可以防止幀率過低時遊戲邏輯變得過於不穩定。

### 使用場景
`maximumDeltaTime` 常用於防止物理系統或動畫系統在低幀率下崩潰或出現不一致的行為。
