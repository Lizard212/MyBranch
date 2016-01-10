#pragma once
#include<iostream>
#define MAX 10
using namespace std;

class CPU_Scheduling
{
	int num_of_processs;    // Number of processes
	int  burst_time[MAX]; // Array to store burst time
	int	arrival_time[MAX]; // Array to store Arrival time
	int wait_time[MAX];    // Array to store waiting time
	int total_wait_tiem;   // Total waiting time
	int average_time;      // Average waiting time
	
	
public:
	// Getting the num of prosess & brust time 
	void Getdata();
	// First come First served Algorithm
	void FCFS();
	// Shortest job First Algorithm
	void SJF();
	// Shortest job First Algorithm with Pre-emption
	void SJFP();
	// Shorsttest job First with NonPreemption
	void SJFNP();
	// Round Robin Algorithm
	void RoundRobin();
	// Priority Algorithm
	void Priority();

	CPU_Scheduling();
	~CPU_Scheduling();
};

