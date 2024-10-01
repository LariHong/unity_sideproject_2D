
## OnDrawGizmos�]ø�s�����p�u��^

`OnDrawGizmos` �O Unity ���ΨӦb Scene ������ø�s�ոչϧΪ���ơC����C������b���������i�ܤ��|�v�T�C���������޿�ε�ı�ĪG�A�u�|�b�s�边�� Scene �������X�{�A�D�n�Ω����U�}�o�̦b��������ı�ƬY�Ǽƾک��޿�C

### 1. **�򥻨ϥ�**
   - **�\��**: 
     - �b����������ø�s�i���ƪ��X��ϧΡ]�p�y��B�ߤ���B�g�u���^�A�q�`�ΨӮi�ܽd��B�I���˴��ϰ�Ψ�L�ݭn��ı�ƪ��ƾڡC
   
   - **��������**:
     - `OnDrawGizmos` �O Unity �s�边�M�Ϊ���ơA�b�s�边�� Scene �������۰ʳQ�եΡA���b�B��ɤ��|�եΡC
     - �}�o�̥i�H�z�L `Gizmos` ���ӨϥΤ��ت�ø�s��k�A�Ҧp `Gizmos.DrawSphere()`�B`Gizmos.DrawLine()` ���C

### 2. **�`��ø�s��k**
   - **Gizmos.DrawSphere(Vector3 center, float radius)**:
     - �b `center` ��mø�s�@�ӫ��w�b�|���y��C
     - **�γ~**: �q�`�ΨӪ��Ĳ�o�ϰ�B�ĤH�P���d�򵥡C
     - **��������**: ø�s���y��Ȧb Scene �������i���A���|�v�T��ڹC�������骺�I���Ϊ��z�ĪG�C

   - **Gizmos.DrawCube(Vector3 center, Vector3 size)**:
     - �b `center` ��mø�s�@�ӫ��w�j�p���ߤ���C
     - **�γ~**: �i�H�Ψ���ܸI�����Χ����d��C
     - **��������**: �P�ˡA�o��ø�s���e�u�|�X�{�b Scene �����A���|�X�{�b�C���B��ɪ��e�����C

   - **Gizmos.DrawLine(Vector3 from, Vector3 to)**:
     - �q `from` �I�e�@���u�� `to` �I�C
     - **�γ~**: �ΨӪ�ܸ��|�B��V�γs����Ӫ��骺���Y�C
     - **��������**: �o�ǽu�q�b Scene �������O�R�A��ܡA�q�`�Ω���ܤ�V�νd��A�K������������W���C

   - **Gizmos.color**:
     - �]�w Gizmos ��ø�s�C��C�Ҧp�A`Gizmos.color = Color.red` �|������ø�s���ϧ���ܬ�����C
     - **�γ~**: �Ϥ����P�������d��Ϊ���]�Ҧp�A�����ܦM�I�ϰ�A����ܦw���ϰ�^�C
     - **��������**: `Gizmos.color` ���v�T�C�����������C��A�u�v�T Scene �������� Gizmos ø�s�C

### 3. **OnDrawGizmos �M OnDrawGizmosSelected ���ϧO**
   - **OnDrawGizmos**:
     - �L�׬O�_�襤�Ӫ���A�u�n�i�J Scene �����AGizmos �N�|��ܡC
   
   - **OnDrawGizmosSelected**:
     - �ȷ�襤�Ӫ���ɡA�~�|��ܸӪ��骺 Gizmos�C
   
   - **��������**: �ϥ� `OnDrawGizmosSelected` �i�H�קK��������ܹL�h�� Gizmos�A�u�b�ոոӪ���ɮi�ܡA��ֵ�ı�z�Z�C

