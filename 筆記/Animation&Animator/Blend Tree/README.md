# Unity Blend Tree �M �ʵe���A�� �ԲӸ���
![](./image.png)
## 1. Blend Tree ����������

### Blend Tree ���z
**Blend Tree** �O Unity �ʵe�t�Ϊ��@�����A���\���ƹL��M�V�X�h�Ӱʵe�A�ھڬY�ǰѼơ]�p�t�סB��V���^�ӰʺA�վ㨤�⪺�ʵe���A�C�o���B�z�������ʧ@�A�p���D�B�]�B�����s�ɪ��L��D�`���ΡC

### yVelocity �����������
�b�� Blend Tree ���A`yVelocity` �ѼƳQ�ΨӨM�w���⪺�����t�סG

- **���Ȫ� yVelocity** ��ܨ���b�W�ɡ]���D�^�A�]�� Blend Tree �N�L��� **PlayerJump** �ʵe�C
- **�t�Ȫ� yVelocity** ��ܨ���b�U���A�]�� Blend Tree �N�L��� **PlayerFall** �ʵe�C
  
�� Blend Tree ������ `yVelocity` ����s�ȮɡA���|�ھڳ]�m���H�ȡ]Threshold�^�ʺA�V�X��Ӱʵe�A�H�T�O�ʵe�L�窺�۵M�M���ơC

### PlayerJump �M PlayerFall ��������������
Blend Tree �ھ� `yVelocity` ���d��ӿ�ܦX�A���ʵe�CUnity �q�L�������[�v��k�ӽT�w��Ӱʵe���V�X��ҡC�p�G `yVelocity` ���� -1 �M 1 �����AUnity �|�v���q PlayerFall �L��� PlayerJump �ΤϤ��C�o���קK�F�������ʵe�����A�q�ӼW�j�F�C�������۵M�P�C

---

## 2. �ʵe���A���]Animator State Machine�^��������
![](./image3.png)
### ���A�������u�@��z
�b Unity �� Animator ���A���A���޲z�۰ʵe�����������C���⪺�Ѽơ]�p `yVelocity`�^�F��Y���H�ȮɡA���A���|Ĳ�o�@�Ӫ��A�L��A�q��e�ʵe������s���ʵe�C

- **Transition�]�L��^**:
  - �L��O Unity ���ʵe���A�������۰ʤ����C�����@�w����ɡ]�Ҧp `yVelocity` �ܬ� 0�^�A���A���N�q `Jump/Fall` �L����L���A�]�p `PlayerIdle`�^�C
  - �L�示���̿�� Unity ���@�M����t�ΡA�ھڳ]�w���Ѽ��ܤƨӨM�w�L��O�_Ĳ�o�C��ѼƹF��L��]�w���H�ȮɡA�t�η|�۰ʶi��ʵe�����C

### Foot IK ������
`Foot IK` ���@�άO�O���������}�b�a���W�C����i����D�Ψ�L�B�ʮɡAFoot IK �T�O�}�����|��z�a�����a�šCUnity �ϥΰf�V�B�ʾǡ]Inverse Kinematics, IK�^�p�⨤��}����m�A�îھڳ��������a�ΰʺA�վ㨤��}�����A�A��{��G�u���ĪG�C

---

## 3. Blend Tree Inspector �]�m����������
![](./image2.png)
### Threshold �p�����
Blend Tree ���� **Thresholds�]�H�ȡ^** �M�w�F�ʵe��ɶ}�l�L��C�C�@���H�ȻP�Ѽƭȡ]�p `yVelocity`�^�����C�� `yVelocity` �b���w�d���ܤƮɡAUnity �N�ھڸӽd�򤺪��ȡA�ʺA�p���Ӱʵe�������V�X��ҡC

�Ҧp�G
- �� `yVelocity` ���� 1 �ɡAPlayerJump �ʵe�|�v���e�D�ɦa��A�� PlayerFall ���v�T�|��z�C
- �� `yVelocity` ���� -1 �ɡAPlayerFall �ʵe�|�e�D�ɦa��C

### �۰��H�Ȫ�����
�p�G�ҥΤF **Automate Thresholds**�AUnity �|�ھڰʵe�����Ǧ۰ʳ]�m�H�ȡA�Ӥ��ݭn��ʽվ�C�o�ϥΤ�����k�A�N�ʵe���u�ʤ�Ҧ۰ʤ��t���Ѽƽd��C�o�ئ۰ʤƪ��L�{���C�F��ʳ]�m�������ʡA�A�X�ݭn�ֳt�]�w��²��ʵe�L��C
