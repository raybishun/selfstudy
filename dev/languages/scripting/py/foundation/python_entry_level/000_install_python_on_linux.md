# Install Python on CentOS

### Prerequisites (i.e. C compiler, etc)
1. sudo yum groupinstall -y "Development Tools"
1. sudo yum install -y zlib-devel openssl-devel

### Fetch bits
1. cd /usr/src
1. wget https://python.org/ftp/python/3.7.3/Python-3.7.3.tar.xz

### Unpack installation bits
1. sudo tar xf Python-3.7.3.tar.xz
1. cd Python-3.7.3

### Generate makefile required to perform the installation
1. sudo ./configure --enable-optimizations --with-ensurepip=install

### Make and perform install
1. sudo make altinstall

### Upgrade pip
1. sudo pip3.7 install --upgrade pip

### Verify path
1. sudo cat /etc/sudoers | grep secure_path
1. Find /usr/local/bin (if not found, add using next line)
1. sudo vim /etc/sudoers
1. Add /usr/local/bin to the secure_path

### Validate that Python is installed
1. python3.7 --version