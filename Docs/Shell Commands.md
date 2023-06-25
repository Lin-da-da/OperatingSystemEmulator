# Miku's OSEmu Shell
Miku's OSEmu Shell, 简称为Msh, 是基于本操作系统模拟器实现的一个简易shell, 为用户提供了控制本模拟器的外壳程序.

Msh不是严格意义上的shell程序, 只能用在本模拟器中.

Msh支持多进程启动.

Msh具有以下功能:
1. 接收用户的输入.
2. 输出文本信息.
3. 提供控制本模拟器的命令.

## Shell固有命令

- `msh [参数...]` : Msh控制指令
	> msh参数  
		`--exit` :  退出shell  
		`--status` :  查看shell当前状态  
		`--version` :  查看shell版本   

## 系统命令接口

### 系统

- `reboot` : 重启系统
- `poweroff` : 自动关闭系统，会依次关闭相关进程
- `shutdown [参数...]` : 强制关闭系统
	> shutdown参数  
		`-f` :  强制关闭系统.  
		`[int value]` : 在`int value`个系统时间刻后关闭系统.  
- `status` : 查看系统状态

### 文件

- `create` : 创建文件
- `mkdir` : 创建目录
- `rm` : 删除文件或目录
- `mv` : 移动文件或目录
- `type <file>` ： 查看文件类型
- `ls` : 列出当前所在目录下的文件和目录

### 设备

- `devices [参数...]` : 查看当前已挂载的设备
	> devices参数  
		`--list` : 列出全部设备  
		`[device name]` : 查看指定设备  
		`--status` : 查看设备状态
- `access [device name]` : 访问设备, 根据设备具体设置决定访问的具体操作

### 程序
执行程序:
- `<executable file name>`: 无参数启动方法
- `start <executable file name> [参数...]` : 含参数启动方法
	> 参数列表   
		`-b` : 后台运行  
		`-n` : 关闭输出  
