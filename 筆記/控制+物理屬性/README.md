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
