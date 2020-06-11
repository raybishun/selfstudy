# Network Setup

ssh ray@ideapad

sudo -i

nmcli dev status

nmcli con add con-name enp3s0 ifname enp3s0 type ethernet ip4 192.168.0.8/24 gw4 192.168.0.1 

nmcli dev status

nmcli con show enp3s0 | less

nmcli con modify enp3s0 ipv4.dns 8.8.8.8

nmcli con modify enp3s0 ipv4.method manual

nmcli con modify enp3s0 connection.autoconnect true (sets ONBOOT=YES)

ifconfig enp3s0

### Verify

cd /etc/sysconfig/network-scripts/

ls -ltr 

more ifcfg-enp3s0

### Troubleshooting

nmcli con down enp3s0

nmcli con up enp3s0