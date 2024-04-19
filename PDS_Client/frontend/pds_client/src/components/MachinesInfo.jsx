import { Link } from 'react-router-dom'

const MachinesInfo = () => {
  return (
    <div className='section mx-auto grid gap-28'>
      {/*  */}
      {/* EQC SECTION */}
      {/*  */}
      <section className='uppercase text-collor1 mt-6 flex flex-col md:flex-row gap-x-6 bg-gray-800 rounded-lg border-collor1 border p-6 shadow-2xl shadow-black mx-auto'>
        <h1 className='md:-rotate-90 w-[4.375rem] mx-auto flex justify-center items-center text-4xl mb-4 md:my-auto lg:text-6xl text-primary tracking-widest'>
          Middlefield
        </h1>
        <div className='flex flex-row gap-x-0 md:gap-x-4 mx-auto lg:w-[28.125rem]'>
          {/*  */}
          <div className='flex flex-col justify-between'>
            <Link to='/Machinesinfo/Eqc1Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>EQC_1</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Eqc2Live' className='btn_2 btn-sm md:btn-lg '>
              <h2 className='centerBtn'>EQC_2</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Eqc3Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>EQC_3</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Eqc4Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>EQC_4</h2>
            </Link>
          </div>
          {/*  */}
          <div className='flex flex-col justify-between'>
            <Link to='/Machinesinfo/Eqc5Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>EQC_5</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Eqc6Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>EQC_6</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Eqc7Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>EQC_7</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Eqc8Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>EQC_8</h2>
            </Link>
          </div>
        </div>
        <img
          src='/machinePicture/eqcMachine.png'
          alt='middlefield machine'
          className='shadow-2xl shadow-black rounded-md w-[18.75rem] md:w-[31.25rem] h-auto mx-auto overflow-hidden'
        />
      </section>
      {/*  */}
      {/* ASQ */}
      {/*  */}
      <section className='uppercase text-collor1 mx-4 flex flex-col md:flex-row gap-x-6 bg-gray-800 rounded-lg border-collor1 border p-6 shadow-2xl shadow-black '>
        <h1 className='md:-rotate-90 w-[4.375rem] mx-auto flex justify-center items-center text-4xl mb-4 md:my-auto lg:text-6xl text-primary tracking-widest'>
          ASQ
        </h1>
        <div className='flex flex-row gap-x-0 md:gap-x-4 my-auto lg:w-[28.125rem]'>
          {/*  */}
          <div className='flex flex-col justify-start'>
            {/*  */}
            <Link to='/Machinesinfo/Asq2Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>ASQ_2</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Asq3Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>ASQ_3</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Asq4Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>ASQ_4</h2>
            </Link>
          </div>
          {/*  */}
          <div className='flex flex-col justify-start'>
            <Link to='/Machinesinfo/Asq5Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>ASQ_5</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/Asq6Live' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>ASQ_6</h2>
            </Link>
          </div>
        </div>
        <img
          src='/machinePicture/asqMachine.png'
          alt='ur'
          className='shadow-2xl shadow-black rounded-md w-[300px] md:w-[31.25rem]  h-auto mx-auto overflow-hidden  '
        />
      </section>
      {/*  */}
      {/* OPEL */}
      {/*  */}
      <section className='uppercase text-collor1 mx-4 flex flex-col md:flex-row gap-x-6 bg-gray-800 rounded-lg border-collor1 border p-6 shadow-2xl shadow-black'>
        <h1 className='md:-rotate-90 w-[4.375rem] mx-auto flex justify-center items-center text-4xl mb-4 md:my-auto lg:text-6xl text-primary tracking-widest'>
          OPEL
        </h1>
        <div className='flex flex-row gap-x-0 md:gap-x-4 my-auto lg:w-[28.125rem]'>
          {/*  */}
          <div className='flex flex-wrap md:flex-wrap mx-auto items-center'>
            {/*  */}
            <Link to='/Machinesinfo/OpelInsertFront' className='btn_2 btn-sm md:btn-lg '>
              <h2 className='centerBtn '>Opel insert Fr</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/OpelInsertRear' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>Opel insert Rr</h2>
            </Link>
            {/*  */}
            <Link to='/Machinesinfo/OpelArmrestFront' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>Opel Armrest Fr</h2>
            </Link>
            <Link to='/Machinesinfo/OpelArmrestRear' className='btn_2 btn-sm md:btn-lg'>
              <h2 className='centerBtn'>Opel Armrest Rr</h2>
            </Link>
          </div>
        </div>
        <img
          src='/machinePicture/armrestMachine.png'
          alt='opel'
          className='shadow-2xl shadow-black rounded-md w-[18.75rem] md:w-[31.25rem]  h-auto mx-auto overflow-hidden '
        />
      </section>
    </div>
  )
}
export default MachinesInfo
