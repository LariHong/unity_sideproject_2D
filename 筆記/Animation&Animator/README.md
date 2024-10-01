# Unity Animator �M Animation 
![](./image.png)
## Animator ����

### 1. **Animator ���A��**
   - **Base Layer**: 
     - �ʵe�������¦�h�A�Ψөw�q�Ҧ��ʵe���A���ഫ�C�C�@�h���i�H�W�߳B�z�ʵe�޿�C
     - ��ϥΦh�h�ɡA���W�h���ʵe�|�л\�U�h�C�i�H�Ω�B�z��������ʵe�A�Ҧp�G�@�h�����ʵe�A�t�@�h��������C
     - **��������**: ��A�b�h�h���ϥΰʵe�ɡA�C�Ӽh�����ۤv���v������A�o�|�M�w���@�h���ʵe�ĪG�̲׮i�ܦb����W�C���h�Űʵe���v���q�`�л\���h�ʵe�C

   - **Any State**: 
     - ��ܥ��N���A�ҥi�q���B������L���A�A�L�ݥ��i�J�S�w���A�C�o�D�`���Ω��_��e�ʵe�åߨ�i�J����ʵe�A�p���`�Ψ����ʵe�C
     - **��������**: ����󺡨��ɡA`Any State` �i�H���L��L���b���񪺪��A�A����Ĳ�o�ʵe�C�o����u���Ū��ʵe�]�p��o�ƥ�ʵe�^�D�`���n�C

   - **Entry**: 
     - ��ܰʵe���i�J�I�A�o�O�ʵe����Ұʫ᪺�Ĥ@�Ӫ��A�A�q�`�Ω�]�w���⪺�q�{�ʵe���A�A�Ҧp�ݾ����A�C

   - **Exit**: 
     - �h�X���A�A��i�J�����A��A�Ӱʵe���A���N�����C�q�`�Ω󵲧��ʵe�L�{�Χ@���Y��Ĳ�o���󪺲פ�A�C

### 2. **Animator �k�W���\��**
   - **Auto Live Link**: 
     - ���\�b���ݭn�I�� Play �����p�U��ɬd�ݰʵe�ĪG�C�o�O�Ψӧֳt�վ�ʵe���K���\��C
   - **�Ѽƺ޲z�]Parameters�^**: 
     - **+ �����s**�G�Ψӷs�W�ѼơC�o�ǰѼƥi�H�b���A�����ഫ�ɨϥΡC�Ѽ������G
       - **Float**: �B�I�ơA�Ω�����ܤƪ��ƾڡ]�p����t�ס^�C
       - **Int**: ��ơA�q�`�Ω�O�����A�A�Ҧp���������q�C
       - **Bool**: ���L�ȡA�q�`�ΨӪ�ܬY�Ӷ}�����A�]�p����O�_�b���D���^�C
       - **Trigger**: Ĳ�o���A�Ω�Ұʤ@���ʰʧ@�]�p�����ʧ@���}�l�^�C
     - **��������**: �C��ѼƳQ���A�ʵe����|�۰��ˬd�Ҧ��������L�����öi��ʵe���A�ഫ�C�Ҧp�A�p�G�Y�� `Bool` �Q�]�m�� `true`�A�h�|�ˬd���������Ĳ�o�������ʵe�L��C

### 3. **�ʵe�L��M����**
   - **�L��]Transition�^**: 
     - �ʵe���A�������L��i�H�q�L�k���I���Y�@���A�ÿ�� ��Make Transition�� �ӳЫءC�L��O�����Ӱʵe���A�p����������١C
     - �L������i�H�]�m���ƹL�窺�ɶ����סA�קK�ʵe������M���ܡC
     - **��������**: �b�ʵe���A�L������AUnity �|�ھڳ]�m���L��ɶ����Ʀa���Ȩ�Ӱʵe���A�A�����̥H���w���t�׹L��C�o�קK�F�ʵe��������a����C

   - **����]Conditions�^**: 
     - �L��i�H�ھڰѼƨӳ]�m����C�Ҧp�G�u����Ѽ� "isJumping" �� `true` �ɡA�~�|�q�ݾ����A��������D���A�C
     - �i�H�b���A���L�窺���󭱪O���]�m����C
     - **��������**: ����O���Ѽƶi��ʱ����A��Ѽƺ����]�m������ɡA�������ʵe�L��N�|�QĲ�o�C�o�ϱo�ʵe�t�Ψ㦳���ת��F���ʡC

### 4. **�k��\����**
   - **Create State**: 
     - �Ψӫإ߷s���ʵe���A�C
     - **Empty**: �إߤ@�ӪŪ����A�C
     - **From New Blend Tree**: �Ыؤ@�ӷs�� Blend Tree ���A�A�Ω�V�X�h�Ӱʵe�C
     - **��������**: Blend Tree �q�L�N�h�Ӱʵe�ھڤ��P���Ѽƶi��V�X�A���ͥ��ƪ��ʵe�L��CUnity �ھڿ�J���ѼưʺA�p��C�Ӱʵe���v���A�æb�B��ɶi���ɲV�X�C
   
   - **Create Sub-State Machine**: �Ыؤ@�Ӥl���A���C�l���A���ΨӲ�´�M�޲z�j���ʵe��������ʵe�޿�A�Ҧp�i�H�N���⪺�W�b���M�U�b�����ʵe�޿���}�B�z�C

   - **Set As Layer Default State**: �]�w�����A���Ӽh���q�{���A�A�ʵe�q���B�}�l����C

   - **Copy / Paste / Delete**: �Ω�ƻs�B�߶K�ΧR���襤�����A�ιL��C

   - **Add Transition**: �ΨӤ�ʲK�[���A�������L��A��ݭn����P�ʵe�����������޿�ɫD�`���ΡC

   - **Toggle Mute**: �Ȯ��R���ʵe���A�A�קK�ʵe�v�T��L���A���ոաC

## Animation ����

### 1. **Animation Clip �s���**
   - **Dopesheet�]����V��^**: 
     - Dopesheet �Ҧ��U�A�i�H��ʬ��ʵe�����P�ݩʡ]�p��m�B����B�Y�񵥡^�Ы�����V�C�z�L��ʮɶ��b�A�i�H�b���P�ɶ��I�W�i��s��C
     - **��������**: Dopesheet �|�H����V���Φ��x�s�C�Ӱʵe�V���ݩ��ܤơAUnity �b�B��ɷ|�۰ʸɥ��o������V�������ȡA�q�Ӳ��ͬy�Z���ʵe�ĪG�C

   - **Curves�]���u�s��^**: 
     - �b Curves �Ҧ��U�A�i�H��T����ʵe�Ѽơ]�p���ʡB����^���ܤƦ��u�A���ʵe�L���[���ƩΨ㦳�u�ʡC
     - **��������**: ���u�s�褹�\�ʵe�v����ʵe���ܤƳt�סC���u���Ϊ��M�w�F�ݩʪ��[�t�δ�t�ĪG�A�q�ӹ�{�p�u�ʲ��ʡB�w�ʵ��ĪG�C

### 2. **Samples�]���˲v�^**
   - **Samples**: �Ψӱ���ʵe�����˲v�]�V�t�v�^�A�o�|�v�T�ʵe���񪺥��ƫסC�Ҧp�A60 ��ܨC���� 60 �V�C���˲v�V���A�ʵe�|��o�V�y�Z�A���]�|�W�[�B�z�t��C
   - **��������**: �ʵe���˲v�|�v�T Unity �p��b�C��������w���V�ơC�����˲v���ʵe�q�`�ݭn��h���귽�Ӵ�V�M�B�z�A���]�i�H���ѧ�ӽo���ʵe�ĪG�C

### 3. **�\����**
   - **Add Property**: 
     - �i�H����e�襤������K�[�@�ӥi�ʵe�ƪ��ݩʡ]�p��m�B����B�Y��^�C�o���ݩʷ|��ܦb Dopesheet �� Curves ���A�åB�i�H�]�w����V�C
     - **��������**: ��K�[�ݩʫ�AUnity �|�N�o���ݩʥ[�J��ʵe�ſ褤�ñN���x�s�b����V�ƾڤ��C�o�ϱo���󪺳o���ݩʥi�H�H�ۮɶ��ܤƦӳQ�ʵe����C

   - **Animation Settings**: 
     - �Ω�վ��e�ʵe�ſ誺�]�m�A�]�A�˥��t�v�B�ʵe�ɪ��B�^��Ҧ��]�p�`������^���C
   
   - **Copy / Paste**: 
     - �i�H�ƻs�M�߶K�w�Ыت�����V�A�ϱo�s��ʵe�ܱo��[�ֳt�C

   - **Create New Clip**: 
     - �Ыطs���ʵe���q�]Clip�^�A�q�`�Ψөw�q���⪺�S�w�欰�]�p�]�B�B���D���^�C

   - **Keyframe �ާ@**:
     - **Insert Keyframe**: ��ʴ��J����V�C
     - **Delete Keyframe**: �R����e�襤������V�C

### 4. **���񱱨�**
   - **Play**: 
     - �����e�ʵe���q�A�i�H�w���s��ĪG�C
   
   - **Record**: 
     - �I�����s���s��A��ק�ʵe�����ݩʮɡA�|�۰ʰO���U�s������V�C

### 5. **Hierarchy�]�h�š^�s��**
   - ���ܳ��������@�ӥi�ʵe�ƪ������AAnimation �����|��ܸӪ��󪺰ʵe�ſ�C

### 6. **No Animatable Object Selected**
   - ��S����ܥ���㦳�ʵe������ɡAAnimation �����|��ܦ����ܡC


## �ʵe�L��]�w

��A��ܤ@�Ӱʵe���A���L��ɡAInspector �����|��ܸӹL�窺�Բӳ]�w�C

### 1. **Transitions�]�L��C��^**
   - **Solo**: 
     - �p�G�Ŀ�A�ӹL��|��W�B��A��L�L��|�Q�����C�A�X�ݭn�u��Ĳ�o���ʵe�L��C
     - **��������**: Solo �L�窺�u���ŷ|�����L�Ҧ��L��A�L�ר�L�L�窺����O�_�����A�t�γ��|������o�ӹL��C
   
   - **Mute**: 
     - �ϸӹL��L�ġA���|�A�o���ഫ�C�o���ոհʵe�D�`�����U�A�i�H�T�άY�ǹL����[��ʵe����{�C
     - **��������**: ��@�ӹL��Q�R���ɡA�ӹL��N���|�Q�ˬd����A�]���L�kĲ�o�������ʵe�����C

### 2. **�L��]�w�]Transition Settings�^**

   - **Has Exit Time**: 
     - �p�G�Ŀ�A�o�ӹL��u���b�ʵe���q�����@�w�ɶ��]�q�`�O�����^��~�|�o�͹L��C
     - **��������**: �� `Has Exit Time` �Q�ҥΡAUnity �|�ھڰʵe���q������i�רӨM�w�O�_�i�H�L���U�@�Ӫ��A�C�o�`�Ω�۵M�L��A�Ҧp�����⪺�����ʧ@���񧹲���A�ഫ���]�B�ʧ@�C

   - **Exit Time**: 
     - �]�w��e�ʵe���q�������Ĳ�o�L��A�q�`�ϥΦʤ���ι�ڮɶ��C�Ҧp�A`0.583` ��ܰʵe���q����� 58.3% �ɵo�͹L��C
     - **��������**: �� `Exit Time` �]�w���p�� 1 ���ȮɡA�ʵe�L��|�b�Ӯɶ��IĲ�o�A���|����ʵe���q�������񧹲��C

   - **Fixed Duration**: 
     - �p�G�Ŀ�A�L�窺�ɶ��N�O�T�w���A������e�ʵe���q���׼v�T�C�����Ŀ��A�L��ɶ��N���ʵe���q�����פ�Ҩӭp��C
     - **��������**: �ϥΩT�w����ɶ��|�ϹL��L�{��[�@�P�A�L�װʵe���q�����u����A�L��ɶ����|�O��í�w�C

   - **Transition Duration**: 
     - �w�q�L�窺����ɶ��]��^�A�L��V���A��Ӱʵe���A�����������V���ơC�q�`�A�Ω��קK�ʵe�����ɪ���M���ܡC
     - **��������**: Unity �b�L������|���Ӱʵe���A�i�洡�ȡA�Ϩ�Ӱʵe���Ʀa�V�X�C�b�L��ɶ����A��Ӱʵe�|�P�ɼ���A�v���|�v���q�@�Ӱʵe�ಾ��t�@�ӡC

   - **Transition Offset**: 
     - �w�q�U�@�Ӱʵe���q�q���Ӯɶ��I�}�l����C�Ҧp�A�]�m 0.5 �N���۹L���U�@�Ӱʵe���q�ɡA�|�q�Ӥ��q�� 50% �}�l����C
     - **��������**: ��L�禳�����q�ɡA�U�@�Ӱʵe���q���|�q�Y�}�l�A�ӬO�q�]�w���ɶ��I�}�l����C�o���U��Ыا��ʺA���ʵe�L��C

   - **Interruption Source**: 
     - �]�m�O�_���\��e�L��Q�t�@�ӹL�礤�_�C�ﶵ�]�A�G
       - **None**: �����\���_�C
       - **Current State**: ��e�ʵe���A�i�H�Q���_�C
       - **Next State**: �U�@�Ӱʵe���A�i�H�Q���_�C
     - **��������**: ���\���_�ɡA�p�G�t�@�Ӱʵe�L�窺���󺡨��A�h�i�H�ߧY�����ܤU�@�Ӫ��A�A�Ӥ�������e�L�秹���C

   - **Ordered Interruption**: 
     - �p�G�Ŀ�A�L��|���ӳ]�w�����ǳQ���_�A�o�i�H�קK�L��b���X�z���ɶ��I�Q���_�C
     - **��������**: ���Ǥ��_�T�O�ʵe�L�窺�y�{��[�i���A�קK�@�Ǥ����n���L�礤�_�A�q�ӫO���ʵe�޿誺����ʡC

### 3. **����]Conditions�^**
   - **����C��**: 
     - �w�q�L��o�ͪ�����C�o�Ǳ���q�`�̿��ѼƭȡC�Ҧp�A�b�Ϥ����A�� `isMoving` �� `true` �ɡA�~�|�q `PlayerIdle` �L��� `PlayerMove` ���A�C
     - **��������**: �C���Ѽƭ��ܧ�ɡA�ʵe�t�η|�ˬd�Ҧ��L�����O�_�����C�p�G���󺡨��A�������L��N�|�QĲ�o�C

   - **+ ���s**: 
     - �i�H�ΨӲK�[��h����ӱ���L��o�ͪ������ʡC�Ҧp�A�A�i�H�]�w�� `isMoving` �� `true` �åB `speed > 5` �ɤ~�i��L��C



