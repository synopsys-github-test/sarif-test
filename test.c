// Copyright (c) 2020 Synopsys, Inc. All rights reserved worldwide.

void bugs()
{
  int x;
  int y;
  int i;
  for(i = 9; i < x; i--) {
    y = x;
  }
}

int main()
{
  bugs();
  return 0;
}
