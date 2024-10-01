## Physics2D（2D 物理系統）

Unity 的 **Physics2D** 是用來模擬 2D 物理效果的工具。它和 3D 物理引擎不同，專門針對平面上的物體進行碰撞檢測、力的作用、重力和物體交互。

### 1. **基本組件**
   Unity 提供了一些核心的 2D 物理組件，每個組件都有其特定功能和內部運作機制。

   #### 1.1 **Rigidbody2D**
   - **功能**: 為 2D 物體添加物理屬性，允許物體受到重力、力和速度的影響。
   - **主要屬性**:
     - **Body Type**:
       - **Dynamic**: 物體會受到所有的物理影響（例如重力和碰撞），這是最常見的選項。
       - **Kinematic**: 物體不受重力影響，但仍然可以通過腳本來移動，適合平台、電梯等物體。
       - **Static**: 物體不會移動，且不會受到物理影響，適合牆壁或地面。
     - **Mass**: 物體的質量，影響物體的動能、慣性和碰撞效果。
     - **Gravity Scale**: 控制物體受到的重力大小，默認為 1，將其設為 0 可以禁用重力。
     - **Drag**: 控制物體的空氣阻力，數值越大，物體的移動速度越快減少。
     - **Angular Drag**: 控制物體的旋轉阻力。

   #### 1.2 **Collider2D**
   - **功能**: 定義物體的碰撞區域，使物體能夠與其他物體發生碰撞。
   - **種類**:
     - **BoxCollider2D**: 為物體添加矩形的碰撞範圍。
     - **CircleCollider2D**: 為物體添加圓形的碰撞範圍。
     - **PolygonCollider2D**: 添加多邊形的碰撞區域，適合不規則的物體形狀。
     - **EdgeCollider2D**: 添加一條邊緣的碰撞範圍，通常用於地面或平面邊界。

   #### 1.3 **Joint2D**
   - **功能**: 連接兩個 2D 物體，允許它們以某種方式互動，例如關節、彈簧等。
   - **種類**:
     - **HingeJoint2D**: 讓兩個物體通過旋轉點（如門鉸鏈）連接在一起。
     - **SpringJoint2D**: 通過彈簧的方式連接兩個物體，允許彈性運動。
     - **DistanceJoint2D**: 保持兩個物體之間的固定距離。

### 2. **碰撞與觸發**
   - **碰撞（Collision）**: 當兩個帶有 `Collider2D` 的物體發生碰撞時，物體之間會進行物理反應，例如反彈、停止等。
   - **觸發（Trigger）**: 將 `Collider2D` 設置為 `isTrigger` 時，物體會穿過該碰撞區域而不發生實際碰撞，但仍會觸發 `OnTriggerEnter2D`、`OnTriggerStay2D` 和 `OnTriggerExit2D` 回調事件。

   #### **OnTriggerEnter2D** (Collider2D other)
   - **功能**: 當其他物體進入設置為 `isTrigger` 的 `Collider2D` 時調用此函數。
   - **參數**:
     - **other**: `Collider2D` 類型的參數，代表進入該 `Trigger` 區域的另一個物體的碰撞體。

   #### **OnTriggerStay2D** (Collider2D other)
   - **功能**: 當其他物體停留在設置為 `isTrigger` 的 `Collider2D` 內時調用此函數。
   - **參數**:
     - **other**: 代表在 `Trigger` 區域內停留的物體的碰撞體。

   #### **OnTriggerExit2D** (Collider2D other)
   - **功能**: 當其他物體離開設置為 `isTrigger` 的 `Collider2D` 時調用此函數。
   - **參數**:
     - **other**: 代表離開 `Trigger` 區域的物體的碰撞體。

### 3. **Physics2D 常用函數**

   #### **Physics2D.Raycast** (Vector2 origin, Vector2 direction, float distance = Mathf.Infinity, int layerMask = DefaultRaycastLayers)
   - **功能**: 從某個點發射射線，檢測它是否與某個 `Collider2D` 相交。
   - **參數**:
     - **origin**: 射線的起點，為一個 `Vector2` 位置。
     - **direction**: 射線的方向，為一個 `Vector2` 方向向量。
     - **distance**: 射線的長度，默認為無限長。
     - **layerMask**: 設定射線會檢測到的圖層，默認為檢測所有圖層。

   #### **Physics2D.OverlapCircle** (Vector2 point, float radius, int layerMask = DefaultRaycastLayers)
   - **功能**: 檢測一個圓形區域內是否有其他 `Collider2D` 存在。
   - **參數**:
     - **point**: 圓心的位置，為一個 `Vector2` 位置。
     - **radius**: 圓的半徑。
     - **layerMask**: 設定會檢測的圖層，默認為檢測所有圖層。

   #### **Physics2D.AddForce** (Vector2 force, ForceMode2D mode = ForceMode2D.Force)
   - **功能**: 對物體施加一個力，使其移動或旋轉。
   - **參數**:
     - **force**: 要施加的力，為一個 `Vector2` 向量。
     - **mode**: 決定力如何施加。默認為 **ForceMode2D.Force**（持續加速），也可以選擇 **ForceMode2D.Impulse**（瞬時衝力）。

