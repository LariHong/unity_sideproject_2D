# unity_sideproject_2D

## Unity Rigidbody 2D
**你提到可以将 2D Physics Material（物理材质）放入 Rigidbody 中，并且看到物理效果，这可能是因为你将 Physics Material 2D 赋给了相关的 Collider，而不是 Rigidbody 本身。**
* Body Type（物体类型）：
Dynamic（动态）：完全受物理模拟的物体，会对外力和碰撞作出反应。
Kinematic（运动学）：不受物理力影响，但可以通过脚本移动。
Static（静态）：固定在场景中的物体，不会移动且不受物理影响。

* Material（材质）：
你可以为刚体分配一个物理材质，用来定义碰撞时的反弹效果和摩擦力。
* Simulated（模拟）：
勾选此选项时，刚体会参与物理模拟。取消勾选后，该物体将不再受到物理系统影响。

* Use Auto Mass（自动质量）：
根据物体的形状和大小自动计算质量。取消勾选可以手动设置质量		。
* Mass（质量）：			
		 物体的质量，影响物体受到的外力的效果。
* Linear Drag（线性阻力）：
控制物体在直线运动时的阻力，值越大，物体的速度降低得越快。
* Angular Drag（角阻力）：
控制物体旋转时的阻力，值越大，物体旋转减速得越快。

* Gravity Scale（重力比例）：
控制物体受重力影响的程度。值为1时表示正常重力，0表示无重力，值大于1时会增加重力效果。

* Collision Detection（碰撞检测）：

	* Discrete（离散）：标准的物理引擎碰撞检测，适用于大多数情况。		
	* Continuous（连续）：用于高速运动物体，以防止它们穿过其他物体而没有检测到碰撞。

* Sleeping Mode（休眠模式）：
			
	* Start Awake（开始时唤醒）：刚体在启动时处于活动状态。			
    * Start Asleep（开始时休眠）：刚体在启动时处于休眠状态，直到外力使其活动。

* Interpolate（插值）：
控制物体的位置更新方式，以改善平滑度

	* None（无）：不使用插值，位置会实时更新。
	* Interpolate（插值）：使用上一帧的位置来平滑当前帧的位置变化。
	* Extrapolate（外推）：根据前一帧的运动趋势预测下一帧的位置。

* Constraints（约束）：
用于限制刚体的移动或旋转，比如可以冻结物体的某个轴向的运动或旋转。


## 舊的 Input System
[看code註解](./Player.cs)

## 新的 Input System
[參考網址](https://www.youtube.com/watch?v=1_s8IIMDKaU)

## [SerializeField]
```
[SerializeField]
private Rigidbody2D rb;
```
***
[SerializeField]：這是一個屬性，用於使私有欄位可以在 Unity 編輯器的 Inspector 面板中顯示和編輯。即使欄位是私有的 (private)，透過 SerializeField，你依然可以在編輯器中手動指派或檢視該欄位。
***
## GetComponent
```
void Start()
{
    rb = GetComponent<Rigidbody2D>();
}
```
***
GetComponent<Rigidbody2D>()，用於取得目前物件上的 Rigidbody2D 元件，並將其賦值給 rb 變數。
***

## velocity
```

rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);

if (Input.GetKeyDown(KeyCode.Space))
{
    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
}
// 如果有水平输入，讓它滚动
if (xInput != 0)
{
    float torque = -xInput * 2; // 使用負號讓滚动方向正确
    rb.AddTorque(torque);
}
else
{
    // 如果没有输入，停止角速度，立即停止滚动
    rb.angularVelocity = 0;
}
```
***
velocity 是 Unity 中用來操控物體速度的屬性，特別是針對有剛體（Rigidbody）的物體。這裡的 rb 代表一個 Rigidbody 或 Rigidbody2D，而 velocity（速度）屬性則是物體在某個時間點上的運動速度向量。

* 在 2D 情況下（Rigidbody2D）：velocity 是一個 Vector2，包含兩個分量：

	* rb.velocity.x：代表物體在 水平（X 軸） 方向上的速度。
	* rb.velocity.y：代表物體在 垂直（Y 軸） 方向上的速度。

* 在 3D 情況下（Rigidbody）：velocity 是一個 Vector3，包含三個分量：

	* rb.velocity.x：代表物體在 X 軸 上的速度。
	* rb.velocity.y：代表物體在 Y 軸 上的速度。
	* rb.velocity.z：代表物體在 Z 軸 上的速度。
	
* 注意事項：
	* 直接設置 velocity 會瞬間改變物體的速度，這可能會覆蓋掉物理引擎的自然運動結果（如重力或碰撞）。
	* 受物理引擎控制：velocity 是受物理引擎控制的，隨著時間推移（例如物體加速、減速或受力影響），這個值會自動更新。
***
