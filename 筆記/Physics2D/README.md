## Physics2D�]2D ���z�t�Ρ^

Unity �� **Physics2D** �O�ΨӼ��� 2D ���z�ĪG���u��C���M 3D ���z�������P�A�M���w�省���W������i��I���˴��B�O���@�ΡB���O�M����椬�C

### 1. **�򥻲ե�**
   Unity ���ѤF�@�Ǯ֤ߪ� 2D ���z�ե�A�C�Ӳե󳣦���S�w�\��M�����B�@����C

   #### 1.1 **Rigidbody2D**
   - **�\��**: �� 2D ����K�[���z�ݩʡA���\������쭫�O�B�O�M�t�ת��v�T�C
   - **�D�n�ݩ�**:
     - **Body Type**:
       - **Dynamic**: ����|����Ҧ������z�v�T�]�Ҧp���O�M�I���^�A�o�O�̱`�����ﶵ�C
       - **Kinematic**: ���餣�����O�v�T�A�����M�i�H�q�L�}���Ӳ��ʡA�A�X���x�B�q�赥����C
       - **Static**: ���餣�|���ʡA�B���|���쪫�z�v�T�A�A�X����Φa���C
     - **Mass**: ���骺��q�A�v�T���骺�ʯ�B�D�ʩM�I���ĪG�C
     - **Gravity Scale**: �������쪺���O�j�p�A�q�{�� 1�A�N��]�� 0 �i�H�T�έ��O�C
     - **Drag**: ����骺�Ů���O�A�ƭȶV�j�A���骺���ʳt�׶V�ִ�֡C
     - **Angular Drag**: ����骺������O�C

   #### 1.2 **Collider2D**
   - **�\��**: �w�q���骺�I���ϰ�A�Ϫ������P��L����o�͸I���C
   - **����**:
     - **BoxCollider2D**: ������K�[�x�Ϊ��I���d��C
     - **CircleCollider2D**: ������K�[��Ϊ��I���d��C
     - **PolygonCollider2D**: �K�[�h��Ϊ��I���ϰ�A�A�X���W�h������Ϊ��C
     - **EdgeCollider2D**: �K�[�@����t���I���d��A�q�`�Ω�a���Υ�����ɡC

   #### 1.3 **Joint2D**
   - **�\��**: �s����� 2D ����A���\���̥H�Y�ؤ覡���ʡA�Ҧp���`�B�u®���C
   - **����**:
     - **HingeJoint2D**: ����Ӫ���q�L�����I�]�p������^�s���b�@�_�C
     - **SpringJoint2D**: �q�L�u®���覡�s����Ӫ���A���\�u�ʹB�ʡC
     - **DistanceJoint2D**: �O����Ӫ��餧�����T�w�Z���C

### 2. **�I���PĲ�o**
   - **�I���]Collision�^**: ���ӱa�� `Collider2D` ������o�͸I���ɡA���餧���|�i�檫�z�����A�Ҧp�ϼu�B����C
   - **Ĳ�o�]Trigger�^**: �N `Collider2D` �]�m�� `isTrigger` �ɡA����|��L�ӸI���ϰ�Ӥ��o�͹�ڸI���A�����|Ĳ�o `OnTriggerEnter2D`�B`OnTriggerStay2D` �M `OnTriggerExit2D` �^�ըƥ�C

   #### **OnTriggerEnter2D** (Collider2D other)
   - **�\��**: ���L����i�J�]�m�� `isTrigger` �� `Collider2D` �ɽեΦ���ơC
   - **�Ѽ�**:
     - **other**: `Collider2D` �������ѼơA�N��i�J�� `Trigger` �ϰ쪺�t�@�Ӫ��骺�I����C

   #### **OnTriggerStay2D** (Collider2D other)
   - **�\��**: ���L���鰱�d�b�]�m�� `isTrigger` �� `Collider2D` ���ɽեΦ���ơC
   - **�Ѽ�**:
     - **other**: �N��b `Trigger` �ϰ줺���d�����骺�I����C

   #### **OnTriggerExit2D** (Collider2D other)
   - **�\��**: ���L�������}�]�m�� `isTrigger` �� `Collider2D` �ɽեΦ���ơC
   - **�Ѽ�**:
     - **other**: �N�����} `Trigger` �ϰ쪺���骺�I����C

### 3. **Physics2D �`�Ψ��**

   #### **Physics2D.Raycast** (Vector2 origin, Vector2 direction, float distance = Mathf.Infinity, int layerMask = DefaultRaycastLayers)
   - **�\��**: �q�Y���I�o�g�g�u�A�˴����O�_�P�Y�� `Collider2D` �ۥ�C
   - **�Ѽ�**:
     - **origin**: �g�u���_�I�A���@�� `Vector2` ��m�C
     - **direction**: �g�u����V�A���@�� `Vector2` ��V�V�q�C
     - **distance**: �g�u�����סA�q�{���L�����C
     - **layerMask**: �]�w�g�u�|�˴��쪺�ϼh�A�q�{���˴��Ҧ��ϼh�C

   #### **Physics2D.OverlapCircle** (Vector2 point, float radius, int layerMask = DefaultRaycastLayers)
   - **�\��**: �˴��@�Ӷ�ΰϰ줺�O�_����L `Collider2D` �s�b�C
   - **�Ѽ�**:
     - **point**: ��ߪ���m�A���@�� `Vector2` ��m�C
     - **radius**: �ꪺ�b�|�C
     - **layerMask**: �]�w�|�˴����ϼh�A�q�{���˴��Ҧ��ϼh�C

   #### **Physics2D.AddForce** (Vector2 force, ForceMode2D mode = ForceMode2D.Force)
   - **�\��**: �磌��I�[�@�ӤO�A�Ϩ䲾�ʩα���C
   - **�Ѽ�**:
     - **force**: �n�I�[���O�A���@�� `Vector2` �V�q�C
     - **mode**: �M�w�O�p��I�[�C�q�{�� **ForceMode2D.Force**�]����[�t�^�A�]�i�H��� **ForceMode2D.Impulse**�]���ɽĤO�^�C

