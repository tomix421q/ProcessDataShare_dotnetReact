import { useRef, useState, useEffect } from 'react'
import { Link } from 'react-router-dom'
import { AiOutlineClose, AiOutlineMenu } from 'react-icons/ai'
import { IoChevronBack } from 'react-icons/io5'
import { ImHome } from 'react-icons/im'

const Navbar = () => {
  const [nav, setNav] = useState(false)
  const navRef = useRef(null)
  const isHomePage = window.location.pathname == '/'

  document.addEventListener('keydown', (event) => {
    if (event.key === 'Backspace') {
      event.preventDefault()
      window.history.go(-1)
    }
  })

  const handleNav = () => {
    setNav(!nav)
  }

  useEffect(() => {
    const handleClickOutside = (event) => {
      if (navRef.current && !navRef.current.contains(event.target)) {
        setNav(false)
      }
    }

    document.addEventListener('mousedown', handleClickOutside)
    return () => {
      document.removeEventListener('mousedown', handleClickOutside)
    }
  }, [navRef])

  return (
    <div className='fixed z-40 flex justify-start cursor-pointer bg-black w-full md:w-fit'>
      <div
        onClick={handleNav}
        className='m-3 flex group transition-all ease-in duration-500 relative  hover:bg-black text-secondary'
      >
        {/*  */}
        {/* Burger */}
        {/*  */}
        <AiOutlineMenu size={50} className='relative z-20 hover:text-collor2' />
        {/* <h4 className='z-10 group-hover:relative hidden fixed group-hover:flex transition-all ease-in duration-200 text-4xl text-primary justify-center items-center pl-3'>
          MENU
        </h4> */}
      </div>
      <div className='m-3 n'>
        <Link to='/' className='flex group transition-all ease-in duration-500 relative  hover:bg-black'>
          {' '}
          <ImHome size={50} className='z-20 relative hover:text-collor2' />
          {/* <h4 className='z-10 group-hover:relative hidden fixed group-hover:flex transition-all ease-in duration-200 text-4xl text-primary justify-center items-center pl-3'>
            HOME
          </h4> */}
        </Link>
      </div>

      <div className='flex items-center group'>
        <a href='/' className='relative'>
          <h4 className='flex flex-col uppercase font-light font-extraFont text-base justify-center items-start tracking-widest  leading-4 px-3'>
            <span>
              <span className='text-collor2 font-semibold'>P</span>rocess
            </span>{' '}
            <span>
              <span className='text-collor1 font-semibold'>D</span>ata
            </span>{' '}
            <span>
              <span className='text-secondary font-semibold'>S</span>hare
            </span>
            <span className='group-hover:border-b ease-in duration-300 w-0 group-hover:w-[70%] absolute h-2 bottom-0 right-2 '></span>
            <span className='group-hover:border-l ease-in duration-300 h-0 group-hover:h-[80%] absolute w-2 right-0 bottom-0'></span>
          </h4>
        </a>
      </div>

      <button
        className={`${isHomePage ? 'hidden' : 'flex'} text-4xl uppercase group my-auto fixed right-0 bg-black p-3`}
        onClick={() => window.history.go(-1)}
      >
        <h4 className='flex flex-row'>
          <IoChevronBack size={50} className='hover:text-collor2'/>
          {/* <span className='z-10 group-hover:relative hidden fixed group-hover:flex transition-all ease-in duration-200 text-4xl text-primary justify-center items-center pl-3'>
            BACK
          </span> */}
        </h4>
      </button>

      <div
        ref={navRef}
        className={
          nav
            ? 'fixed left-0 top-0 w-full md:w-fit h-screen bg-primary ease-out duration-500 z-50'
            : 'fixed left-[-120%] top-0 ease-in duration-1000 h-screen z-50'
        }
      >
        <div
          onClick={handleNav}
          className='p-2 cursor-pointer text-collor2 bg-black w-fit m-3 flex group transition-all ease-in duration-500 relative  hover:bg-black text-secondar'
        >
          <AiOutlineClose size={43} className='relative z-20' />
          <h4 className='z-10 group-hover:relative hidden fixed group-hover:flex transition-all ease-in duration-200 text-4xl text-primary justify-center items-center pl-3'>
            CLOSE
          </h4>
        </div>

        {/* Menu (mobile) */}
        <div className='mx-4 mt-6 text-4xl md:text-7xl text-collor1 flex flex-col h-auto justify-around'>
          <ul className='uppercase'>
            <li className='mb-6 hover:text-collor1 w-fit group relative'>
              <div className='group-hover:w-full bg-black h-full w-0 absolute z-10 transition-all ease-in duration-200'></div>
              <Link to='/' onClick={() => setNav(false)} className='z-20 relative'>
                Home
              </Link>
            </li>
            <li className='mb-6 hover:text-collor1 w-fit group relative'>
              <div className='group-hover:w-full bg-black h-full w-0 absolute z-10 transition-all ease-in duration-200'></div>
              <Link to='/dashboardall' onClick={() => setNav(false)} className='z-20 relative'>
                Dashboard
              </Link>
            </li>
            <li className='mb-6 hover:text-collor1 w-fit group relative'>
              <div className='group-hover:w-full bg-black h-full w-0 absolute z-10 transition-all ease-in duration-200'></div>
              <Link to='/Machinesinfo' onClick={() => setNav(false)} className='z-20 relative'>
                Machines
              </Link>
            </li>
            <li className='mb-6 hover:text-collor1 w-fit group relative'>
              <div className='group-hover:w-full bg-black h-full w-0 absolute z-10 transition-all ease-in duration-200'></div>
              <Link to='/database' onClick={() => setNav(false)} className='z-20 relative'>
                Database
              </Link>
            </li>
            <li className='mb-6 hover:text-collor1 w-fit group relative'>
              <div className='group-hover:w-full bg-black h-full w-0 absolute z-10 transition-all ease-in duration-200'></div>
              <Link to='/connection' onClick={() => setNav(false)} className='z-20 relative'>
                Connection
              </Link>
            </li>
          </ul>
          <div className='mb-6 hover:text-collor1 w-fit group relative text-xl  md:text-3xl uppercase'>
            <div className='group-hover:w-full bg-black h-full w-0 absolute transition-all ease-in duration-200 z-10'></div>
            <a href='mailto: tomas.zilka@yanfeng.com?subject = Feedback&body = Message' className='z-20 relative'>
              Send fault | Idea
            </a>
          </div>
        </div>
      </div>
    </div>
  )
}
export default Navbar
