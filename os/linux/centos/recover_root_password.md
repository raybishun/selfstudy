# Recover Root Password

1. Restart
2. At the GRUB (boot loader) menu, select RHEL Server (not the rescue option)
3. Select 'e' to Edit
4. Find the line that begins with 'linux16'
5. Using your down arrow key, move to that line
6. Using your right arrow key, move to the end of the line
7. Type: rd.break
8. Press: Ctrl X
9. The system will reboot and enter into emergency mode
10. mount
11. Observe the last line shows that rhel-root is mounted on /sysroot as 'read-only'
```
/dev/mapper/rhel-root on /sysroot type xfs (ro,relatime,attr2,inode64,noquota)
```
12. mount -o remount,rw /sysroot (re-mount the file system with read-write access)
13. chroot /sysroot
14. passwd
15. Enter your new password (twice)
16. (All authentication tokens will be updated)
17. exit
18. reboot
19. Verify you are now able to login as root