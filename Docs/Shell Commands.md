# Miku's OSEmu Shell
Miku's OSEmu Shell, ���ΪMsh, �ǻ��ڱ�����ϵͳģ����ʵ�ֵ�һ������shell, Ϊ�û��ṩ�˿��Ʊ�ģ��������ǳ���.

Msh�����ϸ������ϵ�shell����, ֻ�����ڱ�ģ������.

Msh֧�ֶ��������.

Msh�������¹���:
1. �����û�������.
2. ����ı���Ϣ.
3. �ṩ���Ʊ�ģ����������.

## Shell��������

- `msh [����...]` : Msh����ָ��
	> msh����  
		`--new` :  
		`--exit` :  
		`--status` :  

## ϵͳ����ӿ�

### ϵͳ

- `reboot`
- `poweroff`
- `shutdown [����...]`
	> shutdown����  
		`-f` :  ǿ�ƹر�ϵͳ.  
		`[int value]` : ��`int value`��ϵͳʱ��̺�ر�ϵͳ.  
- `status`

### �ļ�

- `create`
- `mkdir`
- `rm`
- `mv`
- `type <file>` : 
- `ls` : �г���ǰ����Ŀ¼�µ��ļ���Ŀ¼

### �豸

- `devices [����...]` : �鿴��ǰ�ѹ��ص��豸
	> devices����  
		`--list` : �г�ȫ���豸  
		`[device name]` : �鿴ָ���豸  
		`--status` : �鿴�豸״̬
- `access [device name]` : �����豸, �����豸�������þ������ʵľ������

### ����
ִ�г���:
- `<executable file name>`: �޲�����������
- `start <executable file name> [����...]` : ��������������
	> �����б�   
		`-b` : ��̨����  
		`-n` : �ر����  

### ����